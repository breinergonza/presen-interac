Feature: Users
![Users](https://firebasestorage.googleapis.com/v0/b/puzzle-app-3ed86.appspot.com/o/users%20(2).jpg?alt=media&token=c8011ab4-f152-45ad-9071-37ca856ad058)
	Como usuario deseo poder registrarme con redes sociales

Caracteristicas: [Users](PresInteractivas.Test/Features/Users.feature)
***Power by***: **[Breitner Gonzalez](http://breinergonza.github.io/)**


@google
Scenario: Como usuario deseo poder registrarme con Google
	Given El nombre del usuario es Juan
	And El apellido es Charrasqueado
	And la fecha de nacimiento es 10/14/1980
	And el tipo de red social a registrar 1
	When se valida el registro
	Then el resultado debe ser true

@facebook
Scenario: Como usuario deseo poder registrarme con Facebook
	Given El nombre del usuario es Pedro
	And El apellido es Paramo
	And la fecha de nacimiento es 01/10/1989
	And el tipo de red social a registrar 2
	When se valida el registro
	Then el resultado debe ser true