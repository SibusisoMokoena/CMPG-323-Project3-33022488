# TelemetryPortal_MVC

The Goal of the Project is to creat a web Application that handles client and project data CRUD (Create,Read,Update,Delete) Functionality. and also to enhance the application the focus is on comprehending and putting architectural patterns, coding concepts and design patterns into practice.

Requirements : 
The Project's needs are separated into functional and non-functional.

**Functional requirements :**
It outline the functions that the application must do, with an emphasis on CRUD procedures for managing client and project data.

**Non-Functional Requirements :** These guarantee that the functional requirements are successfully satisfied by addressing quality qualities including performence, security, and usability.

The following is a prioritized list of the project's essential features and tasks:
1) GitHub Administration : Establish version control by creating and configuring a github repository. keep a README.md file to serve as the project's documentation.
2) Project Setup : Log in to the hosted database and accesss the project taht already exist.
3) Application design Patterns : Make repository classes to handle client and project-related data access operations. for a clear design, move have to move the controllers data access code to the repository.
4) Project Termination : Avoid Keeping private login information in the github repository to maintain security. To host the application in the cloud, create an Azure App Service, publish it, and make sure it's safe and easily accessible. Keep record of all the materials used as a referecne and thoroughly document the project in the README.md.

## How to use the Web App
Open the Application website and navigate to the far right of the navigation bar.
You can register, if already registered you can simply login with the created username and password.

**The Home page looks like this :**
![Screenshot 2024-09-26 222048](https://github.com/user-attachments/assets/19ce8842-7484-491c-a651-b836c031f5ae)

after login you can see on the nav bar the is a client database and projects database.
if you want to add a new client you must first provide the Client Id and fill other details relating to the client.
the id should be a guid not an integer .One can simply generate a unique guid on the following link ( https://guidgenerator.com/ )  as the client id you will have to generate another guid also on the project id. The database is already populated with data then you can just perform the CRUD operations on the right of your database
you can Create, Update or Delete.
**Creating a new Client**

![Screenshot 2024-09-26 214015](https://github.com/user-attachments/assets/16d1c29b-b046-4149-b7cd-5af9568f620a)

**Editing the Details of the existing Client:**

![Screenshot 2024-09-26 214120](https://github.com/user-attachments/assets/1c6e9e0b-8d2e-433e-8ec6-0fa9f3a3c871)

**Deleting the Details of the existing Client**

![Screenshot 2024-09-26 214211](https://github.com/user-attachments/assets/5b146246-5b5d-4774-8c49-136661d95e09)

once you fininish using the app you can simply logout by going to your accont and manage the log in.

## Screenshots of the Visual Code, Creation of ripos and interfaces
![Screenshot 2024-09-26 220148](https://github.com/user-attachments/assets/e9da074e-0ee0-4413-a59f-40553d0bb76c)

## Hosting
I hosted The Web App on my Azure account : 

![Screenshot 2024-09-26 230117](https://github.com/user-attachments/assets/d9c316b4-20cf-4b42-86ff-7cd855b3f04b)





