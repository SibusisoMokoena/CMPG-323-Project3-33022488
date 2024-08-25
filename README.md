# TelemetryPortal_MVC

The Goal of the Project is to creat a web Application that handles client and project data CRUD (Create,Read,Update,Delete) Functionality. and also to enhance the application the focus is on comprehending and putting architectural patterns, coding concepts and design patterns into practice.

Requirements : 
The Project's needs are separated into functional and non-functional.
Functional requirements : It outline the functions that the application must do, with an emphasis on CRUD procedures for managing client and project data.
Non-Functional Requirements : These guarantee that the functional requirements are successfully satisfied by addressing quality qualities including performence, security, and usability.

The following is a prioritized list of the project's essential features and tasks:
1) GitHub Administration : Establish version control by creating and configuring a github repository. keep a README.md file to serve as the project's documentation.
2) Project Setup : Log in to the hosted database and accesss the project taht already exist.
3) Application design Patterns : Make repository classes to handle client and project-related data access operations. for a clear design, move have to move the controllers data access code to the repository.
4) Project Termination : Avoid Keeping private login information in the github repository to maintain security. To host the application in the cloud, create an Azure App Service, publish it, and make sure it's safe and easily accessible. Keep record of all the materials used as a referecne and thoroughly document the project in the README.md.

for the User.
Open the Application website and navigate to the far right of the navigation bar.
You can register, if already you register you can simply login with the created username and password.
after login you can see on the nav bar the is a client database and projects database.
if you want to add a new client you must first provide the Client Id and fill other details relating to the client.
the id should be a guid not an integer
you cant simply generate a unique guid on the following link ( https://guidgenerator.com/ )  as the client id you will have to generate another guid also on the project id.
once the database is populated then you can peerform the CRUD operation on the right of your database
you can Delete, Update or Add.
once you fininish using the app you can simply logout by going to your accont and manage the log in.
