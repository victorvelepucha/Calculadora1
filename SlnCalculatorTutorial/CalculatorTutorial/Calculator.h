#pragma once
class Calculator
{
public:
	double Suma(double x, double y);
	double Resta(double x, double y);
	double Multiplicacion(double x, double y);
	double Division(double x, double y);
	//Calculator();//Constructor
	//~Calculator();//destructor
	double Calculate(double x, char oper, double y);
};

