# This program was create using C# dotnet core 
This prograam can be run using visual studio or from command line interface on a computer donet core installed.
## To run this on visual studio
* Open the in visual studio 
* Click the Build menu on the menu bar > click on Build Solution
* Press the F5 to run the program
## To run from terminal
* Open command line interface and ensure that the dotnet core is installed by running the following command dotnet --info. You should see information about the dotnet installed on your computer.
* Navigate to the solution folder on the command line.
* Run the following command "dotnet run" to start the program.

### How to use program
When you have successfully start the program you should see instruction telling you to enter the table size and starting position of object to simulate. This program only accepts 4 positive whole numbers separated single commas. The table size are the first two numbers and it doesn't accept zero but the starting position which are the last two numbers does. Input for starting positiion on the y axis can't be greater or equal to the height of the table that will mean the object is out of the table. The same goes for the x axis and the width.
Input example 4,4,2,2
#### Command instruction 
The comman input expects string of number between 0 to 4 separate by single commas. The last number most be 0 and if there is a 0 somewhere in this input the program executes to that point display result.
The commands are:
0 = quit simulation and print results to stdout
1 = move forward one step
2 = move backwards one step
3 = rotate clockwise 90 degrees (eg north to east)
4 = rotate counterclockwise 90 degrees (eg west to south)

Commands example 1,4,1,3,2,3,2,4,1,0