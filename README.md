# BucStop
### East Tennessee State University
#### CSCI 4350
#### Built with Love: Fall 23, Spring 24
#### By: Team Bobby, Comm-rads 

### Overview:
This project is a game website made by and for ETSU students. Bucstop acts as a front end for users to browse, play, and rate games. Bucstop calls a Microservice API to retrieve game code for players. The microservice is here: [Micro Service](https://github.com/BucStop-net/GameInfoMicroService_SP24).

### Known Bugs:
[BugLog](https://docs.google.com/document/d/18zQnqhbHpZvoPzhQS3A24BacXtmFW6eH7-32d9fFwlc/edit?usp=sharing)

### Project Structure: 
[Architecture Vision](https://docs.google.com/document/d/1JRDEq0iDyEp96cbt_YUVYm2EnMUxjwyqOOTLxx7t7Fg/edit?usp=sharing) 
To understand the project structure, familiarize yourself with the
MVC (Model View Controller) structure. When clicking on a game, 
an ID value will be passed to the controller, which will send that ID to the MS. The API will then 
send the JS as a string back to Bucstop, where it will run locally.  

* Bucstop
	* Controllers
		* This folder has the controllers, which allow pages to 
			link together and pass information between them.
		* GameController contains the API calls to interact with the MS 
	* Models
		* This folder has the basis for the Game class.
	* Views
		* Games
			* This folder has pages related to games, such as
				the index page and the default game page.
		* Home
			* This folder contains the main pages used by the site, 				
				such as the home page, admin page, and privacy page.
		* Shared 
			* This contains other important pages and/or resources 
				that aren't in the other two folders, including the
				default layout and the error page.
	* wwwroot
		* This folder contains the resources used by the project, 
			including images, icons, etc.
### Deployment Help: 
* We have written instructions and 3 videos to help in deployment. 
	* deployment video 1: [deployment by Sydnie](https://youtu.be/wLctheT-7SE)
	* deployment video 2: [deployment by Taj](https://www.youtube.com/watch?v=HzFFTk4tlOI&t=1041s)
	* deployment for Mac: [deployment by Logan](https://www.youtube.com/watch?v=oK3Olw4wlLs&list=PLLVrCqkyEWa_6qhZhzTfgVTu3WL6ywW2G&index=1)
### Overview Videos:
[BucStop Vision](https://youtu.be/KyqVh7D8oz4)
[Architecture](https://www.youtube.com/watch?v=UBjK1_NDIK0)
#### Contributors:  
> Isaac Camacho, Richard Cashion, Dylan Cowell, Thomas Foreman,
> Dionte Jones, Matt Justis, Jacob Klucher, Dylan Lynch, 
> Caleb Rains, Chris Seals, Kyle Wittman,
> Dylan Pogue, Sydnie Dery, Shealy Cohan, Logan Turbyfill,
> Thomas Justice,  Will Roe, Ben Merrit, Jivan Taj 


### Help
For more documentation on how to run locally and how to set up deployments, see the google docs below:
* [Running Locally](https://docs.google.com/document/d/1gfUpjZNfqWyv1ohUW1IaS8fOhXp0hOx6tFQVXBADa8Q/edit?usp=sharing)
* [How to Deploy](https://docs.google.com/document/d/1MbolrcHgcJCKjInjxEu2orgP7qfAPIBt_-CmevXkIew/edit)
