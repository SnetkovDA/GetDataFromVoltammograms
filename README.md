# Get data from Voltammograms
This software provides you ability to separate dark and light current on voltammogram.

## Project description
* Folder [Simplifier](https://github.com/SnetkovDA/GetDataFromVoltammograms/tree/master/Simplifier) contains full source code 
of the project.

* File [GDFVG.zip](https://github.com/SnetkovDA/GetDataFromVoltammograms/blob/master/GDFVG.zip) is ready to use,
builded version of the project for Windows OS (32 bit).
To run it:
1. Download .zip file.
2. Unzip to any folder.
3. Run GDFVG.exe file.

## How to use this programm?
1. Open file with data. Supports: *.dat, .csv* files.
    CSV file must be constructed in this way:
    - First colomn - time;
    - Second colomn - current;
    - Third colomn - potential; 
    - All colomns should be separated by ";".
2. Choose polynom power to separate source data. (Supported values: 1 - 6).
3. Press "Find points" key.
4. Now you can see plot of inverse values with line separates it into two part.
5. Press Ctrl+R to show two received graphs and finded points.
6. If you satisfied with the result you achive, press Ctrl+S and choose what you want to save. Or if you don't satisfied 
with the result, change parameters and go to step 3.

## Screenshots
Before separation: ![screenshot1](http://picua.org/img/2018-05/27/68u0qbro5vd8vrswk4aekmwvt.png "Before separation.") After separation: ![screenshot2](http://picua.org/img/2018-05/27/h1kyu4i8rjh4lwxvtb2piosmy.png "After separation.")

## Contact information
Created by Dmitriy Snetkov.
E-mail: snetkovdmitriy@mail.ru
