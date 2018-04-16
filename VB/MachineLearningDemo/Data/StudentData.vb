﻿Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text

Namespace MachineLearningDemo.Data
	Public Class StudentData
		Public Shared Function GetData() As Student()
			Return New Student() { New Student With {.Name = "Aidan", .Age = 27, .Friends = 3, .GPA = 0.54, .Grade = Grade.F, .Tall = True, .Good = False}, New Student With {.Name = "Amelia", .Age = 40, .Friends = 7, .GPA = 2.60, .Grade = Grade.A, .Tall = True, .Good = True}, New Student With {.Name = "Noah", .Age = 26, .Friends = 0, .GPA = 2.39, .Grade = Grade.C, .Tall = False, .Good = False}, New Student With {.Name = "Isabella", .Age = 21, .Friends = 9, .GPA = 3.83, .Grade = Grade.A, .Tall = True, .Good = True}, New Student With {.Name = "Liam", .Age = 19, .Friends = 3, .GPA = 1.06, .Grade = Grade.F, .Tall = True, .Good = False}, New Student With {.Name = "Ava", .Age = 16, .Friends = 7, .GPA = 3.31, .Grade = Grade.B, .Tall = False, .Good = True}, New Student With {.Name = "Cayden", .Age = 34, .Friends = 2, .GPA = 1.01, .Grade = Grade.D, .Tall = False, .Good = False}, New Student With {.Name = "Sophia", .Age = 28, .Friends = 13, .GPA = 3.33, .Grade = Grade.A, .Tall = True, .Good = True}, New Student With {.Name = "Ethan", .Age = 21, .Friends = 3, .GPA = 0.33, .Grade = Grade.F, .Tall = True, .Good = False}, New Student With {.Name = "Olivia", .Age = 32, .Friends = 5, .GPA = 3.12, .Grade = Grade.C, .Tall = True, .Good = True}, New Student With {.Name = "Jackson", .Age = 26, .Friends = 0, .GPA = 0.47, .Grade = Grade.C, .Tall = True, .Good = False}, New Student With {.Name = "Madeline", .Age = 40, .Friends = 6, .GPA = 3.63, .Grade = Grade.C, .Tall = True, .Good = True}, New Student With {.Name = "Landon", .Age = 24, .Friends = 1, .GPA = 0.40, .Grade = Grade.D, .Tall = False, .Good = False}, New Student With {.Name = "Lily", .Age = 26, .Friends = 14, .GPA = 3.40, .Grade = Grade.B, .Tall = True, .Good = True}, New Student With {.Name = "Jacob", .Age = 20, .Friends = 3, .GPA = 1.02, .Grade = Grade.F, .Tall = False, .Good = False}, New Student With {.Name = "Abigail", .Age = 32, .Friends = 6, .GPA = 3.10, .Grade = Grade.A, .Tall = True, .Good = True}, New Student With {.Name = "Caleb", .Age = 37, .Friends = 3, .GPA = 1.52, .Grade = Grade.C, .Tall = True, .Good = False}, New Student With {.Name = "Chloe", .Age = 32, .Friends = 10, .GPA = 3.59, .Grade = Grade.B, .Tall = False, .Good = True}, New Student With {.Name = "Lucas", .Age = 28, .Friends = 2, .GPA = 1.66, .Grade = Grade.F, .Tall = True, .Good = False}, New Student With {.Name = "Emma", .Age = 25, .Friends = 13, .GPA = 3.30, .Grade = Grade.A, .Tall = True, .Good = True}, New Student With {.Name = "Braden", .Age = 27, .Friends = 2, .GPA = 2.09, .Grade = Grade.D, .Tall = True, .Good = False}, New Student With {.Name = "Charlotte", .Age = 31, .Friends = 10, .GPA = 3.22, .Grade = Grade.B, .Tall = True, .Good = True}, New Student With {.Name = "Benjamin", .Age = 26, .Friends = 3, .GPA = 0.69, .Grade = Grade.F, .Tall = False, .Good = False}, New Student With {.Name = "Ella", .Age = 38, .Friends = 12, .GPA = 3.78, .Grade = Grade.C, .Tall = True, .Good = True}, New Student With {.Name = "Gavin", .Age = 18, .Friends = 3, .GPA = 1.63, .Grade = Grade.C, .Tall = False, .Good = False}, New Student With {.Name = "Addison", .Age = 27, .Friends = 8, .GPA = 3.65, .Grade = Grade.A, .Tall = True, .Good = True}, New Student With {.Name = "Connor", .Age = 16, .Friends = 0, .GPA = 1.67, .Grade = Grade.C, .Tall = False, .Good = False}, New Student With {.Name = "Elizabeth", .Age = 30, .Friends = 10, .GPA = 2.67, .Grade = Grade.B, .Tall = False, .Good = True}, New Student With {.Name = "Elijah", .Age = 27, .Friends = 1, .GPA = 0.68, .Grade = Grade.F, .Tall = True, .Good = False}, New Student With {.Name = "Grace", .Age = 27, .Friends = 7, .GPA = 2.54, .Grade = Grade.C, .Tall = True, .Good = True}, New Student With {.Name = "Oliver", .Age = 24, .Friends = 3, .GPA = 1.66, .Grade = Grade.C, .Tall = False, .Good = False}, New Student With {.Name = "Audrey", .Age = 26, .Friends = 11, .GPA = 3.86, .Grade = Grade.B, .Tall = False, .Good = True}, New Student With {.Name = "Alexander", .Age = 38, .Friends = 2, .GPA = 0.17, .Grade = Grade.D, .Tall = True, .Good = False}, New Student With {.Name = "Emily", .Age = 23, .Friends = 13, .GPA = 3.83, .Grade = Grade.C, .Tall = False, .Good = True}, New Student With {.Name = "Owen", .Age = 39, .Friends = 2, .GPA = 0.73, .Grade = Grade.F, .Tall = True, .Good = False}, New Student With {.Name = "Bella", .Age = 38, .Friends = 12, .GPA = 2.90, .Grade = Grade.C, .Tall = False, .Good = True}, New Student With {.Name = "Gabriel", .Age = 36, .Friends = 2, .GPA = 2.17, .Grade = Grade.C, .Tall = True, .Good = False}, New Student With {.Name = "Hannah", .Age = 35, .Friends = 12, .GPA = 3.11, .Grade = Grade.C, .Tall = True, .Good = True}, New Student With {.Name = "Logan", .Age = 33, .Friends = 2, .GPA = 1.44, .Grade = Grade.C, .Tall = False, .Good = False}, New Student With {.Name = "Isabelle", .Age = 23, .Friends = 9, .GPA = 3.13, .Grade = Grade.C, .Tall = False, .Good = True}, New Student With {.Name = "William", .Age = 40, .Friends = 1, .GPA = 0.93, .Grade = Grade.C, .Tall = True, .Good = False}, New Student With {.Name = "Scarlett", .Age = 26, .Friends = 14, .GPA = 2.84, .Grade = Grade.C, .Tall = False, .Good = True}, New Student With {.Name = "Tristan", .Age = 37, .Friends = 3, .GPA = 2.44, .Grade = Grade.D, .Tall = True, .Good = False}, New Student With {.Name = "Lila", .Age = 32, .Friends = 14, .GPA = 3.05, .Grade = Grade.C, .Tall = True, .Good = True}, New Student With {.Name = "Jayden", .Age = 19, .Friends = 3, .GPA = 1.38, .Grade = Grade.C, .Tall = False, .Good = False}, New Student With {.Name = "Arianna", .Age = 31, .Friends = 12, .GPA = 3.31, .Grade = Grade.C, .Tall = True, .Good = True}, New Student With {.Name = "Cole", .Age = 26, .Friends = 0, .GPA = 2.21, .Grade = Grade.D, .Tall = False, .Good = False}, New Student With {.Name = "Caitlyn", .Age = 36, .Friends = 7, .GPA = 3.08, .Grade = Grade.C, .Tall = True, .Good = True}, New Student With {.Name = "Asher", .Age = 16, .Friends = 2, .GPA = 2.16, .Grade = Grade.D, .Tall = False, .Good = False}, New Student With {.Name = "Kaylee", .Age = 39, .Friends = 7, .GPA = 3.96, .Grade = Grade.B, .Tall = True, .Good = True}, New Student With {.Name = "Jack", .Age = 19, .Friends = 0, .GPA = 1.04, .Grade = Grade.C, .Tall = True, .Good = False}, New Student With {.Name = "Keira", .Age = 17, .Friends = 10, .GPA = 2.67, .Grade = Grade.C, .Tall = False, .Good = True}, New Student With {.Name = "James", .Age = 33, .Friends = 1, .GPA = 0.74, .Grade = Grade.F, .Tall = False, .Good = False}, New Student With {.Name = "Claire", .Age = 22, .Friends = 12, .GPA = 2.97, .Grade = Grade.B, .Tall = True, .Good = True}, New Student With {.Name = "Chase", .Age = 28, .Friends = 2, .GPA = 1.59, .Grade = Grade.C, .Tall = True, .Good = False}, New Student With {.Name = "Leah", .Age = 39, .Friends = 6, .GPA = 2.99, .Grade = Grade.C, .Tall = False, .Good = True}, New Student With {.Name = "Nathan", .Age = 20, .Friends = 3, .GPA = 1.50, .Grade = Grade.C, .Tall = True, .Good = False}, New Student With {.Name = "Layla", .Age = 33, .Friends = 12, .GPA = 3.53, .Grade = Grade.A, .Tall = False, .Good = True}, New Student With {.Name = "Andrew", .Age = 23, .Friends = 0, .GPA = 0.38, .Grade = Grade.D, .Tall = True, .Good = False}, New Student With {.Name = "Avery", .Age = 27, .Friends = 5, .GPA = 3.51, .Grade = Grade.A, .Tall = True, .Good = True}, New Student With {.Name = "Elliot", .Age = 36, .Friends = 2, .GPA = 0.44, .Grade = Grade.F, .Tall = True, .Good = False}, New Student With {.Name = "Madison", .Age = 39, .Friends = 10, .GPA = 2.65, .Grade = Grade.A, .Tall = False, .Good = True}, New Student With {.Name = "Aaron", .Age = 22, .Friends = 3, .GPA = 1.31, .Grade = Grade.D, .Tall = True, .Good = False}, New Student With {.Name = "Natalie", .Age = 16, .Friends = 13, .GPA = 3.50, .Grade = Grade.A, .Tall = True, .Good = True}, New Student With {.Name = "Colin", .Age = 26, .Friends = 3, .GPA = 0.14, .Grade = Grade.F, .Tall = False, .Good = False}, New Student With {.Name = "Sophie", .Age = 34, .Friends = 6, .GPA = 3.91, .Grade = Grade.C, .Tall = True, .Good = True}, New Student With {.Name = "Grayson", .Age = 20, .Friends = 0, .GPA = 1.70, .Grade = Grade.F, .Tall = False, .Good = False}, New Student With {.Name = "Payton", .Age = 29, .Friends = 7, .GPA = 3.45, .Grade = Grade.B, .Tall = True, .Good = True}, New Student With {.Name = "Mason", .Age = 40, .Friends = 1, .GPA = 0.08, .Grade = Grade.C, .Tall = True, .Good = False}, New Student With {.Name = "Hayley", .Age = 26, .Friends = 13, .GPA = 3.83, .Grade = Grade.B, .Tall = True, .Good = True}, New Student With {.Name = "Nicholas", .Age = 25, .Friends = 2, .GPA = 2.35, .Grade = Grade.D, .Tall = False, .Good = False}, New Student With {.Name = "Violet", .Age = 28, .Friends = 9, .GPA = 3.03, .Grade = Grade.B, .Tall = True, .Good = True}, New Student With {.Name = "Joshua", .Age = 25, .Friends = 0, .GPA = 0.85, .Grade = Grade.C, .Tall = True, .Good = False}, New Student With {.Name = "Sadie", .Age = 24, .Friends = 14, .GPA = 2.87, .Grade = Grade.A, .Tall = False, .Good = True}, New Student With {.Name = "Dylan", .Age = 20, .Friends = 0, .GPA = 1.25, .Grade = Grade.F, .Tall = False, .Good = False}, New Student With {.Name = "Lucy", .Age = 37, .Friends = 7, .GPA = 3.33, .Grade = Grade.A, .Tall = False, .Good = True}, New Student With {.Name = "Isaac", .Age = 37, .Friends = 1, .GPA = 0.18, .Grade = Grade.C, .Tall = False, .Good = False}, New Student With {.Name = "Nora", .Age = 19, .Friends = 9, .GPA = 2.81, .Grade = Grade.C, .Tall = True, .Good = True}, New Student With {.Name = "Matthew", .Age = 32, .Friends = 3, .GPA = 2.48, .Grade = Grade.C, .Tall = False, .Good = False}, New Student With {.Name = "Alice", .Age = 21, .Friends = 14, .GPA = 3.71, .Grade = Grade.B, .Tall = True, .Good = True}, New Student With {.Name = "Levi", .Age = 37, .Friends = 0, .GPA = 0.23, .Grade = Grade.F, .Tall = True, .Good = False}, New Student With {.Name = "Cailyn", .Age = 35, .Friends = 9, .GPA = 2.53, .Grade = Grade.A, .Tall = False, .Good = True}, New Student With {.Name = "Jasper", .Age = 23, .Friends = 0, .GPA = 1.39, .Grade = Grade.C, .Tall = True, .Good = False}, New Student With {.Name = "Savannah", .Age = 39, .Friends = 10, .GPA = 3.06, .Grade = Grade.B, .Tall = True, .Good = True}, New Student With {.Name = "Zachary", .Age = 24, .Friends = 3, .GPA = 1.14, .Grade = Grade.D, .Tall = False, .Good = False}, New Student With {.Name = "Adrianna", .Age = 26, .Friends = 13, .GPA = 3.11, .Grade = Grade.A, .Tall = True, .Good = True}, New Student With {.Name = "Carter", .Age = 34, .Friends = 3, .GPA = 2.22, .Grade = Grade.D, .Tall = True, .Good = False}, New Student With {.Name = "Anna", .Age = 34, .Friends = 14, .GPA = 3.94, .Grade = Grade.B, .Tall = True, .Good = True}, New Student With {.Name = "Nathaniel", .Age = 39, .Friends = 0, .GPA = 0.19, .Grade = Grade.F, .Tall = True, .Good = False}, New Student With {.Name = "Riley", .Age = 29, .Friends = 5, .GPA = 3.32, .Grade = Grade.C, .Tall = True, .Good = True}, New Student With {.Name = "Evan", .Age = 30, .Friends = 1, .GPA = 0.81, .Grade = Grade.D, .Tall = False, .Good = False}, New Student With {.Name = "Annabelle", .Age = 22, .Friends = 14, .GPA = 3.42, .Grade = Grade.B, .Tall = True, .Good = True}, New Student With {.Name = "Sebastian", .Age = 25, .Friends = 2, .GPA = 2.31, .Grade = Grade.C, .Tall = True, .Good = False}, New Student With {.Name = "Callie", .Age = 30, .Friends = 14, .GPA = 3.69, .Grade = Grade.B, .Tall = True, .Good = True}, New Student With {.Name = "Dominic", .Age = 18, .Friends = 0, .GPA = 0.53, .Grade = Grade.C, .Tall = True, .Good = False}, New Student With {.Name = "Paige", .Age = 35, .Friends = 10, .GPA = 3.34, .Grade = Grade.C, .Tall = True, .Good = True}, New Student With {.Name = "Wyatt", .Age = 20, .Friends = 2, .GPA = 1.73, .Grade = Grade.C, .Tall = True, .Good = False}, New Student With {.Name = "Alexis", .Age = 24, .Friends = 11, .GPA = 2.82, .Grade = Grade.B, .Tall = True, .Good = True}, New Student With {.Name = "Henry", .Age = 38, .Friends = 1, .GPA = 0.84, .Grade = Grade.D, .Tall = False, .Good = False}, New Student With {.Name = "Mia", .Age = 32, .Friends = 7, .GPA = 3.70, .Grade = Grade.A, .Tall = True, .Good = True}, New Student With {.Name = "Ryan", .Age = 19, .Friends = 3, .GPA = 0.03, .Grade = Grade.C, .Tall = True, .Good = False}, New Student With {.Name = "Evelyn", .Age = 20, .Friends = 5, .GPA = 2.54, .Grade = Grade.B, .Tall = False, .Good = True}, New Student With {.Name = "Michael", .Age = 34, .Friends = 2, .GPA = 1.88, .Grade = Grade.C, .Tall = True, .Good = False}, New Student With {.Name = "Kylie", .Age = 28, .Friends = 6, .GPA = 3.09, .Grade = Grade.C, .Tall = False, .Good = True}, New Student With {.Name = "Luke", .Age = 18, .Friends = 0, .GPA = 0.72, .Grade = Grade.F, .Tall = False, .Good = False}, New Student With {.Name = "Maya", .Age = 36, .Friends = 10, .GPA = 2.55, .Grade = Grade.A, .Tall = False, .Good = True}, New Student With {.Name = "Emmett", .Age = 26, .Friends = 1, .GPA = 1.65, .Grade = Grade.C, .Tall = True, .Good = False}, New Student With {.Name = "Aurora", .Age = 18, .Friends = 12, .GPA = 3.79, .Grade = Grade.C, .Tall = False, .Good = True}, New Student With {.Name = "Ian", .Age = 16, .Friends = 1, .GPA = 2.24, .Grade = Grade.C, .Tall = True, .Good = False}, New Student With {.Name = "Zoe", .Age = 21, .Friends = 13, .GPA = 3.92, .Grade = Grade.B, .Tall = False, .Good = True}, New Student With {.Name = "Micah", .Age = 28, .Friends = 3, .GPA = 2.48, .Grade = Grade.F, .Tall = True, .Good = False}, New Student With {.Name = "Alyssa", .Age = 27, .Friends = 5, .GPA = 3.96, .Grade = Grade.A, .Tall = True, .Good = True}, New Student With {.Name = "Finn", .Age = 19, .Friends = 1, .GPA = 0.19, .Grade = Grade.C, .Tall = True, .Good = False}, New Student With {.Name = "Juliet", .Age = 21, .Friends = 7, .GPA = 3.30, .Grade = Grade.B, .Tall = True, .Good = True}, New Student With {.Name = "Samuel", .Age = 23, .Friends = 3, .GPA = 1.00, .Grade = Grade.C, .Tall = False, .Good = False}, New Student With {.Name = "Eva", .Age = 36, .Friends = 13, .GPA = 3.17, .Grade = Grade.C, .Tall = False, .Good = True}, New Student With {.Name = "Adam", .Age = 40, .Friends = 2, .GPA = 2.31, .Grade = Grade.C, .Tall = True, .Good = False}, New Student With {.Name = "Michaela", .Age = 28, .Friends = 6, .GPA = 3.85, .Grade = Grade.C, .Tall = False, .Good = True}, New Student With {.Name = "Xander", .Age = 24, .Friends = 1, .GPA = 2.40, .Grade = Grade.D, .Tall = False, .Good = False}, New Student With {.Name = "Vivienne", .Age = 40, .Friends = 8, .GPA = 3.14, .Grade = Grade.B, .Tall = False, .Good = True}, New Student With {.Name = "Daniel", .Age = 37, .Friends = 2, .GPA = 2.37, .Grade = Grade.D, .Tall = True, .Good = False}, New Student With {.Name = "Ashlyn", .Age = 33, .Friends = 6, .GPA = 4.01, .Grade = Grade.A, .Tall = True, .Good = True}, New Student With {.Name = "Seth", .Age = 27, .Friends = 0, .GPA = 1.44, .Grade = Grade.D, .Tall = False, .Good = False}, New Student With {.Name = "Gabriella", .Age = 21, .Friends = 12, .GPA = 3.12, .Grade = Grade.A, .Tall = False, .Good = True}, New Student With {.Name = "Parker", .Age = 20, .Friends = 3, .GPA = 1.44, .Grade = Grade.C, .Tall = False, .Good = False}, New Student With {.Name = "Allison", .Age = 21, .Friends = 11, .GPA = 2.69, .Grade = Grade.A, .Tall = False, .Good = True}, New Student With {.Name = "Ryder", .Age = 38, .Friends = 1, .GPA = 0.57, .Grade = Grade.C, .Tall = True, .Good = False}, New Student With {.Name = "Cadence", .Age = 38, .Friends = 5, .GPA = 2.71, .Grade = Grade.C, .Tall = False, .Good = True}, New Student With {.Name = "Edward", .Age = 25, .Friends = 0, .GPA = 2.29, .Grade = Grade.D, .Tall = True, .Good = False}, New Student With {.Name = "Lillian", .Age = 39, .Friends = 5, .GPA = 3.65, .Grade = Grade.C, .Tall = False, .Good = True}, New Student With {.Name = "Xavier", .Age = 28, .Friends = 2, .GPA = 0.89, .Grade = Grade.D, .Tall = False, .Good = False}, New Student With {.Name = "Stella", .Age = 16, .Friends = 9, .GPA = 3.57, .Grade = Grade.C, .Tall = True, .Good = True}, New Student With {.Name = "Max", .Age = 35, .Friends = 3, .GPA = 0.61, .Grade = Grade.F, .Tall = True, .Good = False}, New Student With {.Name = "Sarah", .Age = 29, .Friends = 7, .GPA = 3.41, .Grade = Grade.B, .Tall = False, .Good = True}, New Student With {.Name = "Damien", .Age = 28, .Friends = 1, .GPA = 0.69, .Grade = Grade.C, .Tall = True, .Good = False}, New Student With {.Name = "Caroline", .Age = 28, .Friends = 6, .GPA = 2.77, .Grade = Grade.C, .Tall = False, .Good = True}, New Student With {.Name = "Jonah", .Age = 18, .Friends = 3, .GPA = 0.93, .Grade = Grade.C, .Tall = True, .Good = False}, New Student With {.Name = "Sienna", .Age = 19, .Friends = 11, .GPA = 2.52, .Grade = Grade.B, .Tall = True, .Good = True}, New Student With {.Name = "Miles", .Age = 21, .Friends = 2, .GPA = 0.38, .Grade = Grade.D, .Tall = False, .Good = False}, New Student With {.Name = "Lauren", .Age = 26, .Friends = 11, .GPA = 3.29, .Grade = Grade.A, .Tall = False, .Good = True}, New Student With {.Name = "Adrian", .Age = 17, .Friends = 0, .GPA = 1.70, .Grade = Grade.C, .Tall = True, .Good = False}, New Student With {.Name = "Aubrey", .Age = 31, .Friends = 11, .GPA = 3.47, .Grade = Grade.B, .Tall = False, .Good = True}, New Student With {.Name = "Tyler", .Age = 26, .Friends = 0, .GPA = 2.09, .Grade = Grade.F, .Tall = True, .Good = False}, New Student With {.Name = "Autumn", .Age = 24, .Friends = 6, .GPA = 3.31, .Grade = Grade.A, .Tall = False, .Good = True}, New Student With {.Name = "Christopher", .Age = 25, .Friends = 2, .GPA = 1.68, .Grade = Grade.F, .Tall = False, .Good = False}, New Student With {.Name = "Aaliyah", .Age = 33, .Friends = 6, .GPA = 3.81, .Grade = Grade.B, .Tall = True, .Good = True}, New Student With {.Name = "Isaiah", .Age = 37, .Friends = 3, .GPA = 2.37, .Grade = Grade.D, .Tall = False, .Good = False}, New Student With {.Name = "Victoria", .Age = 28, .Friends = 9, .GPA = 3.98, .Grade = Grade.A, .Tall = True, .Good = True}, New Student With {.Name = "Carson", .Age = 32, .Friends = 0, .GPA = 1.62, .Grade = Grade.C, .Tall = False, .Good = False}, New Student With {.Name = "Ruby", .Age = 34, .Friends = 8, .GPA = 3.13, .Grade = Grade.B, .Tall = True, .Good = True}, New Student With {.Name = "Eli", .Age = 40, .Friends = 2, .GPA = 0.32, .Grade = Grade.C, .Tall = False, .Good = False}, New Student With {.Name = "Catherine", .Age = 36, .Friends = 10, .GPA = 2.51, .Grade = Grade.B, .Tall = False, .Good = True}, New Student With {.Name = "Thomas", .Age = 21, .Friends = 1, .GPA = 0.82, .Grade = Grade.C, .Tall = True, .Good = False}, New Student With {.Name = "Alexandra", .Age = 23, .Friends = 11, .GPA = 2.87, .Grade = Grade.C, .Tall = True, .Good = True}, New Student With {.Name = "Holden", .Age = 17, .Friends = 3, .GPA = 1.66, .Grade = Grade.C, .Tall = False, .Good = False}, New Student With {.Name = "Samantha", .Age = 26, .Friends = 9, .GPA = 3.89, .Grade = Grade.B, .Tall = False, .Good = True}, New Student With {.Name = "Hayden", .Age = 23, .Friends = 1, .GPA = 1.97, .Grade = Grade.F, .Tall = True, .Good = False}, New Student With {.Name = "Bailey", .Age = 19, .Friends = 12, .GPA = 2.87, .Grade = Grade.C, .Tall = False, .Good = True}, New Student With {.Name = "David", .Age = 17, .Friends = 0, .GPA = 2.06, .Grade = Grade.C, .Tall = True, .Good = False}, New Student With {.Name = "Harper", .Age = 25, .Friends = 8, .GPA = 3.39, .Grade = Grade.C, .Tall = False, .Good = True}, New Student With {.Name = "Cameron", .Age = 40, .Friends = 2, .GPA = 2.39, .Grade = Grade.D, .Tall = True, .Good = False}, New Student With {.Name = "Jillian", .Age = 38, .Friends = 10, .GPA = 3.28, .Grade = Grade.C, .Tall = True, .Good = True}, New Student With {.Name = "Joseph", .Age = 20, .Friends = 1, .GPA = 1.92, .Grade = Grade.F, .Tall = False, .Good = False}, New Student With {.Name = "Mackenzie", .Age = 26, .Friends = 8, .GPA = 2.83, .Grade = Grade.A, .Tall = True, .Good = True}, New Student With {.Name = "Austin", .Age = 38, .Friends = 2, .GPA = 1.63, .Grade = Grade.D, .Tall = False, .Good = False}, New Student With {.Name = "Alexa", .Age = 19, .Friends = 12, .GPA = 3.37, .Grade = Grade.C, .Tall = True, .Good = True}, New Student With {.Name = "Hunter", .Age = 26, .Friends = 1, .GPA = 0.42, .Grade = Grade.C, .Tall = True, .Good = False}, New Student With {.Name = "Esme", .Age = 38, .Friends = 10, .GPA = 3.24, .Grade = Grade.C, .Tall = True, .Good = True}, New Student With {.Name = "Colton", .Age = 28, .Friends = 1, .GPA = 1.34, .Grade = Grade.C, .Tall = True, .Good = False}, New Student With {.Name = "Gabrielle", .Age = 33, .Friends = 8, .GPA = 2.51, .Grade = Grade.B, .Tall = True, .Good = True}, New Student With {.Name = "Brody", .Age = 40, .Friends = 0, .GPA = 1.00, .Grade = Grade.C, .Tall = False, .Good = False}, New Student With {.Name = "Lydia", .Age = 20, .Friends = 7, .GPA = 2.65, .Grade = Grade.C, .Tall = True, .Good = True}, New Student With {.Name = "Blake", .Age = 22, .Friends = 2, .GPA = 1.25, .Grade = Grade.D, .Tall = False, .Good = False}, New Student With {.Name = "Kayla", .Age = 37, .Friends = 14, .GPA = 4.06, .Grade = Grade.B, .Tall = True, .Good = True}, New Student With {.Name = "Rhys", .Age = 35, .Friends = 3, .GPA = 1.69, .Grade = Grade.C, .Tall = False, .Good = False}, New Student With {.Name = "Rosalie", .Age = 39, .Friends = 8, .GPA = 3.40, .Grade = Grade.C, .Tall = False, .Good = True}, New Student With {.Name = "Gage", .Age = 35, .Friends = 3, .GPA = 1.07, .Grade = Grade.C, .Tall = False, .Good = False}, New Student With {.Name = "Zoey", .Age = 25, .Friends = 9, .GPA = 4.10, .Grade = Grade.C, .Tall = True, .Good = True}, New Student With {.Name = "Jonathan", .Age = 32, .Friends = 0, .GPA = 1.72, .Grade = Grade.D, .Tall = False, .Good = False}, New Student With {.Name = "Brianna", .Age = 35, .Friends = 9, .GPA = 2.66, .Grade = Grade.B, .Tall = False, .Good = True}, New Student With {.Name = "Riley", .Age = 23, .Friends = 1, .GPA = 0.61, .Grade = Grade.C, .Tall = True, .Good = False}, New Student With {.Name = "Isla", .Age = 22, .Friends = 5, .GPA = 3.55, .Grade = Grade.A, .Tall = False, .Good = True}, New Student With {.Name = "Joel", .Age = 40, .Friends = 1, .GPA = 1.15, .Grade = Grade.C, .Tall = False, .Good = False}, New Student With {.Name = "Taylor", .Age = 18, .Friends = 11, .GPA = 3.64, .Grade = Grade.B, .Tall = False, .Good = True}, New Student With {.Name = "Brandon", .Age = 31, .Friends = 0, .GPA = 1.16, .Grade = Grade.C, .Tall = True, .Good = False}, New Student With {.Name = "Brooke", .Age = 25, .Friends = 9, .GPA = 2.72, .Grade = Grade.C, .Tall = True, .Good = True}, New Student With {.Name = "Jude", .Age = 17, .Friends = 0, .GPA = 1.44, .Grade = Grade.F, .Tall = True, .Good = False}, New Student With {.Name = "Adalyn", .Age = 18, .Friends = 9, .GPA = 2.66, .Grade = Grade.B, .Tall = True, .Good = True}, New Student With {.Name = "Jason", .Age = 32, .Friends = 1, .GPA = 1.03, .Grade = Grade.C, .Tall = True, .Good = False}, New Student With {.Name = "Lorelei", .Age = 26, .Friends = 8, .GPA = 4.04, .Grade = Grade.A, .Tall = False, .Good = True}, New Student With {.Name = "Anthony", .Age = 28, .Friends = 3, .GPA = 0.89, .Grade = Grade.C, .Tall = False, .Good = False}, New Student With {.Name = "Julia", .Age = 21, .Friends = 8, .GPA = 3.86, .Grade = Grade.A, .Tall = True, .Good = True}, New Student With {.Name = "Nolan", .Age = 34, .Friends = 1, .GPA = 1.86, .Grade = Grade.F, .Tall = False, .Good = False}, New Student With {.Name = "Reagan", .Age = 34, .Friends = 7, .GPA = 3.71, .Grade = Grade.B, .Tall = False, .Good = True}, New Student With {.Name = "Cooper", .Age = 37, .Friends = 2, .GPA = 1.13, .Grade = Grade.D, .Tall = True, .Good = False}, New Student With {.Name = "Faith", .Age = 23, .Friends = 9, .GPA = 2.63, .Grade = Grade.A, .Tall = True, .Good = True}, New Student With {.Name = "Maddox", .Age = 21, .Friends = 3, .GPA = 2.30, .Grade = Grade.D, .Tall = True, .Good = False}, New Student With {.Name = "Sydney", .Age = 39, .Friends = 7, .GPA = 2.64, .Grade = Grade.A, .Tall = False, .Good = True}, New Student With {.Name = "John", .Age = 22, .Friends = 1, .GPA = 1.17, .Grade = Grade.C, .Tall = False, .Good = False}, New Student With {.Name = "Jasmine", .Age = 20, .Friends = 8, .GPA = 2.53, .Grade = Grade.B, .Tall = False, .Good = True} }
		End Function
	End Class
End Namespace
