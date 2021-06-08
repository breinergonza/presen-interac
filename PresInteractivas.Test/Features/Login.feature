Feature: Login
![Login](https://firebasestorage.googleapis.com/v0/b/puzzle-app-3ed86.appspot.com/o/nextauth%20(2).jpg?alt=media&token=ed41aecb-7b3f-4c61-a2c6-81d7a1b83e96)
Como usuario deseo poder autenticarme con la red social con la que me registre

Caracteristicas: [Login](PresInteractivas.Test/Features/Login.feature)
***Power by***: **[Breitner Gonzalez](http://breinergonza.github.io/)**

@google
Scenario: Como usuario deseo poder autenticarme con Google
	Given El usuario breinergonza@hotmail.com
	And El password admin123
	And el tipo de red social es 1
	When se valida el login
	Then el resultado debera ser true

@facebook
Scenario: Como usuario deseo poder autenticarme con Facebbok
	Given El usuario breinergonza@hotmail.com
	And El password admin123
	And el tipo de red social es 2
	When se valida el login
	Then el resultado debera ser true