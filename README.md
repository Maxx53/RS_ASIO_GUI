# RS_ASIO_GUI
Simple GUI for https://github.com/mdias/rs_asio


## Features
* Provides simple GUI that allows you edit RS_ASIO settings easy without opening RS_ASIO.ini in text editor.
* Reads ASIO drivers names from registry, no need to look into RS_ASIO-log.txt anymore.
* Uses [AsioDriver class from NAudio project](https://github.com/naudio/NAudio/blob/master/NAudio/Wave/Asio/ASIODriver.cs) to reading driver info and opening control panel.


## Tips
* Place EXE-file into Rocksmith directory, near RS_ASIO.ini
* ASIO driver control panel can be opened by "Config" button
* Button "OK" is for saving RS_ASIO.ini and closing RS_ASIO_GUI
* Button "Cancel" is for closing RS_ASIO_GUI without saving RS_ASIO.ini
* Button "Run Rocksmith" saving RS_ASIO.ini, running Steam version of Rocksmith 2014 and closing RS_ASIO_GUI


## Screenshot
![Steam Icon](https://maxx.illuzor.com/img/rsgui.png)
