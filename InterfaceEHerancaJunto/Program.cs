﻿// See https://aka.ms/new-console-template for more information
using InterfaceEHerancaJunto.Model.Entities;
using InterfaceEHerancaJunto.Model.Enums;

IShape s1 = new Circle() { Radius = 2.0, Color = Color.White };
IShape s2 = new Rectangle() { Width = 3.5, Height = 2.0, Color = Color.Black };

Console.WriteLine(s1);
Console.WriteLine(s2);