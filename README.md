# BEST CUISINE RESTAURANTS

#### by Aitana Shough and Richard Cha

## Technologies Used

* C#
* .NET 6
* ASP.NET
* 

## Description



## Setup/Installation Requirements

#### You will need the following installed on your machine:
* [.NET SDK](https://dotnet.microsoft.com/en-us/download/dotnet/6.0)
* [MySQLWorkbench](https://dev.mysql.com/downloads/workbench/)

To view this project, clone this repository by pasting the following command into your terminal:
```
git clone https://github.com/REPO-NAME-JERE
```
#### Get copy of MySQL database
1. Clone this repo to your workspace.
2. Open MySQLWorkbench
3. Under Administration Tab, select Data Import/Restore
  * Select 'Import from Self Contained File'
  * Select **../best_cuisine_restaurants_export.sql** from the BestCuisineRestaurant directory
  ![Screenshot of MySQL Import Settings](https://cdn.discordapp.com/attachments/819376827901411358/1054874623931596880/image.png)
  * Select "New..." and set new schema name to **best_cuisine_restaurants**
  * Select 'Start Import'
4. You should now have a copy of the **best_cuisine_restaurants** database on your machine.

#### Open project

#### Directions after cloning are as follows:
1. Open the `BestCuisineRestaurant` directory within your command line.
2. Use `cd BestCuisineRestaurant` to navigate to the main program folder.
3. Install dependencies with `dotnet restore`.
4. Run program with `dotnet run`.

## Known Bugs

* No known bugs at this time.

## License

#### MIT License

Copyright (c) 2022 Aitana Shough, Richard Cha

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, 
INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR 
PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS 
BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT,
TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE
OR OTHER DEALINGS IN THE SOFTWARE.