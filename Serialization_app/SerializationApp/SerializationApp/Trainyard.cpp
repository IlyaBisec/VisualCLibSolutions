#include "Trainyard.h"


std::string Train::getDestination() const
{
    return m_destination;
}

std::string Train::getTrainNumber() const
{
    return m_trainNumber;
}

std::string Train::getDepartureTime() const
{
    return m_departureTime;
}

bool Train::operator<(const Train& other) const
{
    return m_departureTime < other.m_departureTime;
}

void Station::addTrain(const Train &train)
{
    m_trains.push_back(train);
}

void Station::printTrainByNumber(const std::string &trainNumber) const
{
    for (const auto &train : m_trains) {
        if (train.getTrainNumber() == trainNumber) {
            std::cout << "Train: " << trainNumber << std::endl;
            std::cout << "Destination: " << train.getDestination() << std::endl;
            std::cout << "Departure Time: " << train.getDepartureTime() << std::endl;
            return;
        }
    }
    std::cout << "Train with number " << trainNumber << " not found." << std::endl;
}

void Station::printTrainsAfterTime(const std::string &time) const
{
    std::cout << "Trains departing after " << time << ":" << std::endl;
    for (const auto &train : m_trains) {
        if (train.getDepartureTime() > time) {
            std::cout << "Train: " << train.getTrainNumber() << std::endl;
            std::cout << "Destination: " << train.getDestination() << std::endl;
            std::cout << "Departure Time: " << train.getDepartureTime() << std::endl;
        }
    }
    std::cout << std::endl;
}

void Station::printTrainsToDestination(const std::string &destination) const
{
    std::cout << "Trains to " << destination << ":" << std::endl;
    for (const auto &train : m_trains) {
        if (train.getDestination() == destination) {
            std::cout << "Train: " << train.getTrainNumber() << std::endl;
            std::cout << "Destination: " << train.getDestination() << std::endl;
            std::cout << "Departure Time: " << train.getDepartureTime() << std::endl;
        }
    }
    std::cout << std::endl;
}

bool Station::operator<(const Station &other) const
{
    return m_trains < other.m_trains;
}


// Serialization in binary format

void Train::binarySerialize(const Train &obj, const std::string& fileName)
{
    std::ofstream file(fileName + ".binary", std::ios::binary);
    if (file)
    {
        file.write((char*)&obj.m_destination + '\n', sizeof((char *)&obj.m_destination));
        file.write((char *)&obj.m_trainNumber + '\n', sizeof((char *)&obj.m_trainNumber));
        file.write((char *)&obj.m_departureTime + '\n', sizeof((char *)&obj.m_departureTime));
        file.close();
    }
}

void Train::binaryDeserialize(const std::string& fileName)
{
    Train train;
    std::ifstream file(fileName + ".binary", std::ios::binary);
    if (file)
    {
        //file.read((char*)&train, sizeof(Train));
        file.read((char *)&train.m_destination + '\n', sizeof((char *)&train.m_destination));
        file.read((char *)&train.m_trainNumber + '\n', sizeof((char *)&train.m_trainNumber));
        file.read((char *)&train.m_departureTime + '\n', sizeof((char *)&train.m_departureTime));
        file.close();
    }
}

void Station::binarySerialize(const Station &obj, const std::string &fileName)
{
    std::ofstream file(fileName + ".binary", std::ios::binary);
    if (file)
    {
        file.write((char *)&obj, sizeof(Station));
        file.close();
    }
}

void Station::binaryDeserialize(const std::string &fileName)
{
    Station station;
    std::ifstream file(fileName + ".binary", std::ios::binary);
    if (file)
    {
        file.read((char *)&station, sizeof(Station));
        file.close();
    }
}


 // Serialization in XML format
void Train::xmlSerialize(const Train &obj, const std::string &fileName)
{
    rapidxml::xml_document<> doc;

    rapidxml::xml_node<> *root = doc.allocate_node(rapidxml::node_type::node_element, "Train");
    doc.append_node(root);

    rapidxml::xml_node<> *trainNumberNode = doc.allocate_node(rapidxml::node_type::node_element, "TrainNumber", obj.m_trainNumber.c_str());
    root->append_node(trainNumberNode);

    rapidxml::xml_node<> *destinationNode = doc.allocate_node(rapidxml::node_type::node_element, "Destination", obj.m_destination.c_str());
    root->append_node(destinationNode);

    rapidxml::xml_node<> *departureTimeNode = doc.allocate_node(rapidxml::node_type::node_element, "DepartureTime", obj.m_departureTime.c_str());
    root->append_node(departureTimeNode);

    std::ofstream file(fileName + ".xml");
    file << doc;
    file.close();
}

// There is no point in doing de/serialization for the station
Train Train::xmlDeserialize(const std::string &fileName)
{
    Train train;

    std::ifstream file(fileName + ".xml");
    std::stringstream buffer;
    buffer << file.rdbuf();
    file.close();

    std::string xmlContent = buffer.str();

    rapidxml::xml_document<> doc;
    doc.parse<0>(&xmlContent[0]);

    rapidxml::xml_node<> *root = doc.first_node("Train");
    if (root)
    {
        rapidxml::xml_node<> *trainNumberNode = root->first_node("TrainNumber");
        if (trainNumberNode)
        {
            train.m_trainNumber = trainNumberNode->value();
        }

        rapidxml::xml_node<> *destinationNode = root->first_node("Destination");
        if (destinationNode)
        {
            train.m_destination = destinationNode->value();
        }

        rapidxml::xml_node<> *departureTimeNode = root->first_node("DepartureTime");
        if (departureTimeNode)
        {
            train.m_departureTime = departureTimeNode->value();
        }
    }

    return train;
}

void Station::xmlSerialize(const Station &obj, const std::string &fileName)
{
    rapidxml::xml_document<> doc;

    rapidxml::xml_node<> *root = doc.allocate_node(rapidxml::node_type::node_element, "Station");
    doc.append_node(root);

    rapidxml::xml_node<> *trainList = doc.allocate_node(rapidxml::node_type::node_element, "TrainList", (char *)&obj);
    root->append_node(trainList);

    std::ofstream file(fileName + ".xml");
    file << doc;
    file.close();
}



Station Station::xmlDeserialize(const std::string &fileName)
{
    Station station;
   /* Station station;

    std::ifstream file(fileName + ".xml");
    std::stringstream buffer;
    buffer << file.rdbuf();
    file.close();

    std::string xmlContent = buffer.str();

    rapidxml::xml_document<> doc;
    doc.parse<0>(&xmlContent[0]);

    rapidxml::xml_node<> *root = doc.first_node("Station");
    if (root)
    {
        rapidxml::xml_node<> *trainList = root->first_node("TrainList");
        if (trainList)
        {
            station.m_trains[0] = (Station)trainList->value();
        }

    }

    return station;*/

    return station;
}



