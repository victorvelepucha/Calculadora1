#include "pch.h"
#include "Calculator.h"
#include <iostream>

using namespace std;

int main()
{
	double valor1=0, valor2=0, valor3=0;
	char operacion = '\0';

	cout << "Calculadora en consola" << endl << endl;
	cout << "Por favor ingrese la oparacion en este formato: a+b | a-b | a*b | a/b" << endl;
	while (true)
	{
		cin >> valor1 >> operacion >> valor2;
		Calculator calcular;
		valor3 = calcular.Calculate(valor1, operacion, valor2);
		cout << "El resultado es" << valor3  << endl;
	}
	return 0;
}
