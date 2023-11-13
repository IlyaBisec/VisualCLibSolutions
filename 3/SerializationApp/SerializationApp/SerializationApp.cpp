#include "Trainyard.h"

#include "window/MainWindow.h"



int main()
{


    /*form myForm;

    label lb{ myForm, rectangle{10,10,100,100} };
    lb.caption("Hello everybody!");
    myForm.show();*/

    Train train1("Moscow", "123", "08:00");
    Train train2("Saint Petersburg", "456", "10:30");
    Train train3("Kazan", "789", "07:45");


    /*train1.binarySerialize(train1, "binTrain1");
    train2.binarySerialize(train2, "binTrain2");
    train3.binarySerialize(train3, "binTrain3");*/

    train1.xmlSerialize(train1, "xmlTrain1");
    train2.xmlSerialize(train1, "xmlTrain2");
    train3.xmlSerialize(train1, "xmlTrain3");

    std::cout << "Binary and xml serialization finished \n\n\n";



    /*Station station;

    station.addTrain(train1);
    station.addTrain(train2);
    station.addTrain(train3);

    station.binarySerialize(station, "xmlStation");
    station.xmlSerialize(station, "xmlStation");*/


    /*station.printTrainByNumber("456");

    station.printTrainsAfterTime("08:00");

    station.printTrainsToDestination("Moscow");*/

    train1.xmlSerialize(train1, "xmlTrain2");
    train1.getTrainNumber();
    train1.getTrainNumber();
    //station.printTrainByNumber("456");
    //station.printTrainsAfterTime("08:00");

    return 0;

}