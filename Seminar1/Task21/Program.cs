﻿/*  Задача 21: Напишите программу, которая принимает 
на вход координаты двух точек и находит 
расстояние между ними в 2D пространстве.
 
A (3,6); B (2,1) -> 5,09 
A (7,-5); B (1,-1) -> 7,21 

int x1 = -7;
int x2 = 8;
int y1 = 2;
int y2 = -5;

double distance = Math.Sqrt(Math.Pow(x1 - x2,2) + Math.Pow (y1 - y2, 2));

Console.WriteLine(distance);

Задача 21: Напишите программу, которая принимает на 
вход координаты двух точек и находит расстояние 
между ними в 3D пространстве. */

int x1 = 4567;
int y1 = 4;
int z1 = 9;

int x2 = 505094;
int y2 = 23843;
int z2 = 4328;


double distance = Math.Pow((Math.Pow(x1 - x2,2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2,2)), 1/2);
Console.WriteLine(distance);

// Выдает ответ 1 каждый раз, даже когда меняю цифры :(