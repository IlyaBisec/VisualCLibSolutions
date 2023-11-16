#pragma once
#include "stdafx.h"

#include "../RapidXML/RapidXML/rapidxml_print.hpp"
#include "../RapidXML/RapidXML/rapidxml.hpp"
#include "../RapidXML/RapidXML/rapidxml_utils.hpp"

using namespace rapidxml;


class Train
{
public:
    Train() {}
    Train(const std::string &destination, const std::string &trainNumber, const std::string &departureTime)
        : m_destination(destination), m_trainNumber(trainNumber), m_departureTime(departureTime)
    {
    }

    // Getters for getting the state of an object
    std::string getDestination() const;
    std::string getTrainNumber() const;
    std::string getDepartureTime() const;

    // Operator overload < to compare the departure time of two trains
    bool operator<(const Train &other) const;

    // Serialization in binary format
    void binarySerialize(const Train &obj, const std::string &fileName);
    void binaryDeserialize(const std::string &fileName);

    // Serialization in XML format
    void xmlSerialize(const Train &obj, const std::string &fileName);
    Train xmlDeserialize(const std::string &fileName);

private:
    std::string m_destination;
    std::string m_trainNumber;
    std::string m_departureTime;

};

class Station
{
public:
    Station(){}
    ~Station(){}

    void addTrain(const Train &train);

    // Displaying information about the train by number using the index
    void printTrainByNumber(const std::string &trainNumber) const;

    // Displaying information about trains departing after a given time
    void printTrainsAfterTime(const std::string &time) const;

    // Output of information about trains departing to a given destination
    void printTrainsToDestination(const std::string &destination) const;

    // Overloading the comparison operator to sort trains by departure time
    bool operator<(const Station &other) const;

    // Serialization in binary format
    void binarySerialize(const Station &obj, const std::string &fileName);
    void binaryDeserialize(const std::string &fileName);

    // Serialization in XML format
    void xmlSerialize(const Station &obj, const std::string &fileName);
    Station xmlDeserialize(const std::string &fileName);

private:
    std::vector<Train> m_trains;

};




