## About
The Pothole Detector is a group project and developed during the course Pervasive Systems.
<center>
<svg xmlns="http://www.w3.org/2000/svg" width="428" height="222" viewBox="0 0 428 222">
  <polygon fill="#FFF" fill-rule="evenodd" stroke="#000" points="1 1 167.295 1 172.977 18.705 167.295 23.514 167.295 30.915 179.719 30.915 192.231 54.738 222.996 41.886 230.226 59.835 261.437 46.603 261.437 23.514 254.767 18.705 261.437 7.79 273.209 7.79 280.766 1 427 1 208.954 222"/>
</svg>
</center>

## Submodules
These modules were being developed during the group project.

**PotholesDetectorGPSLoRa** is Arduino project for GPS managment and LoRa communcation. Once I2C message is received with the number of pothole detected, it transmits the message via LoRa with GPS position and the number of potholes.

**STM32F401RE-PotholeDetector** is Nucleo-STM32F401RE and X-NUCLEO-IKS01A2 code about Free Fall Detection and sending though SPI. Visit the repository for more.

**PotholeDetectorWebApp** is a web app for visualizing the data received from LoRa. The data can be seen on table view and is exportable as a dataset. The app also offers heatmap for better visualization.

## Used board and sensor
 The application uses [X-NUCLEO-IKS01A2](http://www.st.com/en/ecosystems/x-nucleo-iks01a2.html)'s built-in [LSM6DSL](http://www.st.com/en/mems-and-sensors/lsm6dsl.html) accelerometer sensor on top of the [NUCLEO-F401RE](http://www.st.com/en/ecosystems/x-nucleo-iks01a2.html) board.
 For communcation between STM32 board and LoRa receiver and GPS position [Seeduino LoRaWAN](https://www.seeedstudio.com/Seeeduino-LoRaWAN-p-2780.html) is being used.
 For communication between LoRa network and PC (via serial port) [Adafruit Feather M0 Radio with LoRa Radio Module](https://www.adafruit.com/product/3178) and  is being used.

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
| Onar Alili     | [https://www.linkedin.com/in/onaralili/](https://www.linkedin.com/in/onaralili/)  | PotholeDetectorWebApp |
| Claudio Pastorini      | [https://www.linkedin.com/in/claudio-pastorini/](https://www.linkedin.com/in/claudio-pastorini/)       | PotholesDetectorGPSLoRa |
| Michele La Malva | [https://www.linkedin.com/in/michele-la-malva-moreno/](https://www.linkedin.com/in/michele-la-malva-moreno/)      | STM32F401RE-PotholeDetector |
