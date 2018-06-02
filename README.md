<p align="center">
  <img src="https://raw.githubusercontent.com/onaralili/pothole-detector-project/master/PotholeDetectorWebApp/wwwroot/images/logo.svg?sanitize=true" width="150">
</p>

## About
The **Pothole Detector** is a group project and developed during the course **Pervasive Systems** A.A. 2017/2018 - University of Roma La Sapienza. 

The prototype is able to detect potholes on roads using accelerometer and report back to a remote server. 
There is also a web app which allows user to visualize and view data collected by the device. 

Read above for detail information.

## Submodules
These modules were being developed during the group project.

* `PotholesDetectorGPSLoRa` is Arduino project for **GPS managment and LoRa communcation**. Once I²C message is received with the number of pothole detected, it transmits the message via LoRa with GPS position and the number of potholes. 
Visit the [repository](https://github.com/claudiopastorini/PotholesDetectorGPSLoRa) for more

* `STM32F401RE-PotholeDetector` is Nucleo-STM32F401RE and X-NUCLEO-IKS01A2 code about **free fall detection** and sending though I²C. 
Visit the [repository](https://github.com/Mickyleitor/STM32F401RE-PotholeDetector/tree/afc81e0565daf053700544a7067f0d9a2bb6e741) for more.

* `PotholeDetectorWebApp` is a web app for **visualizing the data received** from LoRa. The data can be seen on table view and is exportable as a dataset. The app also offers heatmap for better visualization.

* `node-serialport-reader` is a node app that **reads data from via serial port**. We used this app to read and insert incoming data to database. 
Visit the [repository](https://github.com/onaralili/node-serialport-reader) for more.

## Used board and sensor
 The application uses:

* [NUCLEO-F401RE](http://www.st.com/en/ecosystems/x-nucleo-iks01a2.html): for the detection of the potholes and the communication with the Seeduino board,
    * [X-NUCLEO-IKS01A2](http://www.st.com/en/ecosystems/x-nucleo-iks01a2.html)'s built-in [LSM6DSL](http://www.st.com/en/mems-and-sensors/lsm6dsl.html) accelerometer sensor on top of the board.
* [Seeduino LoRaWAN](https://www.seeedstudio.com/Seeeduino-LoRaWAN-p-2780.html): for communcation between STM32 board and transmit GPS position via LoRa,
* [Adafruit Feather M0 Radio with LoRa Radio Module](https://www.adafruit.com/product/3178): for communication between LoRa network and PC (via serial port)

## Build
Follow the each repository for building the devices.

#### Build for PotholeDetectorWebApp
The app is written in .NET Core with a bunch of JavaScript libraries such as heatmap.js for visualizing and DataTables for viewing and exporting the data.
Building is straightforward. Clone the app and build it using Visual Studio or Visual Studio Code.

## Screenshots/Pictures
<img src="https://raw.githubusercontent.com/onaralili/pothole-detector-project/master/img.jpg"/>
<img src="https://raw.githubusercontent.com/onaralili/pothole-detector-project/master/Screen%20Shot%202018-06-01%20at%2011.23.15%20AM.png"/>
<img src="https://raw.githubusercontent.com/onaralili/pothole-detector-project/master/Screen%20Shot%202018-06-01%20at%2011.28.41%20AM.png"/>

## Credits
| Student        | LinkedIn           | Project  |
| ------------- |-------------| -----|
| Onar Alili     | [https://www.linkedin.com/in/onaralili/](https://www.linkedin.com/in/onaralili/) | PotholeDetectorWebApp, [node-serialport-reader](https://github.com/onaralili/node-serialport-reader)|
| Claudio Pastorini      | [https://www.linkedin.com/in/claudio-pastorini/](https://www.linkedin.com/in/claudio-pastorini/)       | [PotholesDetectorGPSLoRa](https://github.com/claudiopastorini/PotholesDetectorGPSLoRa) |
| Michele La Malva | [https://www.linkedin.com/in/michele-la-malva-moreno/](https://www.linkedin.com/in/michele-la-malva-moreno/)      | [STM32F401RE-PotholeDetector](https://github.com/Mickyleitor/STM32F401RE-PotholeDetector/tree/afc81e0565daf053700544a7067f0d9a2bb6e741) |
