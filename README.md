


# PhoneBook Console App

This project is an basic Console App example.
In the project the main theme is a PhoneBook list with a few options.

### Used tools
- Asp.Net Console App with `.Net5.0` framework.
- No Database used in this project.
- To be able to show the Dbs, dummy datas generated in Entity folder.

## Insight
- In the project, just basic c# and Linq libraries has been used.
-  Getting the input from user in the terminal and searching in the list.
```c
	var searchType = Convert.ToInt32(Console.ReadLine().Trim());
    if (searchType == 1)
    {
	    Console.Write("Aramak istediğiniz ismi veya soyismi giriniz: ");
        var nameToSearch = Convert.ToString(Console.ReadLine().Trim());
        Console.WriteLine("--");

        searchedPeople = listOfPeople.Where(p => p.Name == nameToSearch || p.Surname == nameToSearch).ToList();
	}
```

## Installation
- To download the project
````
	git clone https://github.com/mhtaldmr/phoneBookConsoleApp.git
````
- To enter the file
````
	cd phoneBookConsoleApp/
	cd ProjectOne
````
- To run the project
````
	dotnet run
````

## Usage
- After run the project in the terminal, screen will be shown:
<img src="https://github.com/mhtaldmr/phoneBookConsoleApp/blob/main/src/menu.PNG" alt="menu" />
- To add a new record
<img src="https://github.com/mhtaldmr/phoneBookConsoleApp/blob/main/src/add.PNG" alt="menu" />
- To add a update a record
<img src="https://github.com/mhtaldmr/phoneBookConsoleApp/blob/main/src/update.PNG" alt="menu" />
- To add a list a record
<img src="https://github.com/mhtaldmr/phoneBookConsoleApp/blob/main/src/listing.PNG" alt="menu" />

---
