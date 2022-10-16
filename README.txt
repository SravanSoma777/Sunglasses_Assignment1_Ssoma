1025 2022/10/12 started the project 

-enabled https configuration
-enabled runtime 
-configured individual accounts
-Commented out the port number in the properties/launchsettings.json

1148 2022/10/12 done with 2 points of the assignment given 
i.e.,
-modified the title of the project page to reflect the company name with link to the product catalogue page
-added an additional page called about us to include the information of the fictional company ,location,staff and description of the model
-now onto changing and ccustomizing the project to include images and modifyng default styles of the application.


1238 2022/10/12 

--Added a class file called Sunglasses to define my classes properties and attributes
		-name
		-ReleaseDate
		-ShadeType
		-Price
		-Review
		-ReviewScale(this was added later when the instructions said i needed one range input for the product rview from 1-5(from excellent to poor))
		-Country

1430 2022/10/13

--Created a DbContext file class and made sure the connecting is all good and changed all default connection strings from defaulkt dbcontext to the one that was created
--Made changes in the files 
		-Startup.cs
		-appsetting.Json

1530 2022/10/13

--Added a Scaffolding item in the Controllers Folders and named it SunglassesController.cs to control CRUD pages
--Added a new property ReviewScale to bind in the controller create and edit Methods.

1730 2022/10/13

--Added Migrations for the class file which has the properties for the product using 

		-Add-Migration initialCreate -Context MvcSunglassesContext
		and 
		-Update-Database -Context MvcSunglassesContext

--Added a class file to inlcude seed data when there is nothing in the database then this data 
appears.
--Added 10 products to the seedData file and update database using the above command
--And Changed the header titles link to access the index Page of the CRUD pages instead of the
home for the default application

1830 2022/10/13

--Changed the Program.cs file to initialise the data given in the seeddata file when the specified
database table doesnt have any data and tested successfully

-------------

1730 2022/10/14

--changing some fonts and background color of the list and footer 
--gave h1 a font family of Bradley Hand ITC
----added these styles to the file _layout.cshtml
        <style>
                li{
                    font-family:'Lucida Sans', 'Lucida Sans Regular', 'Lucida Grande', 'Lucida Sans Unicode', Geneva, Verdana, sans-serif;
                    font-weight:900;
                    margin-right:10px;
                    background-color:burlywood;
                }
                footer{
                    font-family:Castellar;
                    background-color:antiquewhite;
                }
                #heading{
                    font-family:Bahnschrift;
                    font-size:30px;
                }
            </style>
---Made date and time in the footer to be dynamic using @DateTime.Now . as instructed.



1820 2022/10/14

--Added  images in the wwwroot folder creating a new img folder besides js lib and css folders
--Added some styles in the AboutUs page and images in the AboutUs page
            p{
                font-variant:small-caps;
            }
            h2{
                background-color:beige;
                font-family:'Adobe Devanagari';
            }
            img{
                width:500px;
                float:right;
            }

--Added these styles to the home/index file 

            
                      #imgContainer{
                        margin:auto;
                        width:900px;
                        border-bottom:black solid 10px;
                        background-color:antiquewhite;
                    }
                    #img1{
                        width:400px;
                    }
                    #img2{
                        width:400px;
                    }
                    h1{
                        font-family:Cinzel;
                        font-weight:900;
                    }
                    p{
                        text-decoration:underline;
                    }

--------------------------------------
1830 2022/10/14

--Added these styles for the table and fonts in the Sunglasses/Index.cshtml

        <style>
    body{
        font-family:'Gill Sans', 'Gill Sans MT', Calibri, 'Trebuchet MS', sans-serif;
    }
    thead{
        color:white;
        background-color:black;
        font-family:'Arial Rounded MT';
    }
    td{
        color:white;
        background-color:gray;
    }
    .table{
        font-family:Euphorigenic;
    }
</style>


1900 2022/10/14

--Added a new property as mentioned earlier called ReviewScale with input type range
        and added migration for the new property using Add-Migration ReviewScale -context MvcSunglassesContext
---Changed the seed data file data from the random or default value for the properties to giving them different values.

--Changed 
        Views/Sunglasses/Create.cshtml
        -to show input for the new property.
---------------------------------------------------
2200 2022/10/15

--Added a new README.md file to the repository to inlcude a bigger idea of the assignments given and done
--Updated the About us file 












