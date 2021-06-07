Feature: Login
![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
Simple calculator for adding **two** numbers

Link to a feature: [Calculator](PresInteractivas.Test/Features/Calculator.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**

@mytag
Scenario: Validar usuario
	Given El usuario es breinergonza@hotmail.com
	And El password es admin123
	When se valida el login
	Then el resultado debe ser true