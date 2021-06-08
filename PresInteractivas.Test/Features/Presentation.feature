Feature: Presentation
![Presentation](https://firebasestorage.googleapis.com/v0/b/puzzle-app-3ed86.appspot.com/o/pres.jpg?alt=media&token=9d4cd26b-7e13-4f24-8b92-739fe645a006)
Como usuario deseo poder administrar aplicaciones web 

Caracteristicas: [Presentation](PresInteractivas.Test/Features/Presentation.feature)
***Power by***: **[Breitner Gonzalez](http://breinergonza.github.io/)**	

@presentation
Scenario: Como usuario deseo poder crear una nueva presentación web 
	Given el nombre de la presentacion es Presentacion Cuatro
	And el usuario es el 4
	When cuando la presentacion es creada
	Then la respuesta debe ser true