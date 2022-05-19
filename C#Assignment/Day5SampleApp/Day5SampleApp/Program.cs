// See https://aka.ms/new-console-template for more information

using Day5SampleApp;

ArithmeticOperations ao = new ArithmeticOperations();
MathDelegate math = new MathDelegate(ao.Addition);
// math(10, 20); 30
math += ao.Subtraction;
math(10, 20);//30, 10