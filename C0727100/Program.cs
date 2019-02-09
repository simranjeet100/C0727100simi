﻿using System;



namespace CO727100

{

    class Program

    {

        static void Main(string[] args)

        {

            Elevator e = new Elevator();

            e.setup();

            e.TraverseList();

        }

    }



    class Node

    {

        public Node() { }

        public Node elevatorUp;

        public string FloorNumber;

    }



    class Department

    {

        public Department(string dept_name)
        {

            DepartmentDescription = dept_name;

        }

        public Department nextDepartment;

        public Department previousDepartment;

        public string DepartmentDescription;

    }



    class DepartmentStore

    {

        public void InitializeDepartments()

        {

            Department Books = new Department("Books");

            Department Kitchenware = new Department("Kitchenware");



            Kitchenware.nextDepartment = Books;

            Kitchenware.previousDepartment = FirstFloor;

            Department Books = new Department("Books");



        }



    }



    class Elevator

    {

        public static Node Head;

        public static Node FirstFloor;

        public static Node SecondFloor;

        public static Node ThirdFloor;

        public static Node FourthFloor;



        public void setup()

        {

            FirstFloor = new Node();

            SecondFloor = new Node();

            ThirdFloor = new Node();

            FourthFloor = new Node();

            Head = FirstFloor;

            FirstFloor.FloorNumber = "First Floor";

            FirstFloor.elevatorUp = SecondFloor;

            SecondFloor.FloorNumber = "Second Floor";

            SecondFloor.elevatorUp = ThirdFloor;

            ThirdFloor.FloorNumber = "Third Floor";

            ThirdFloor.elevatorUp = FourthFloor;

            FourthFloor.FloorNumber = "Fourth Floor";

            FourthFloor.elevatorUp = null;

        }



        public void TraverseList()

        {

            Node temp;

            temp = Head;



            // where am I going to start?



            while (temp != null)

            {

                Console.WriteLine(temp.FloorNumber);

                temp = temp.elevatorUp;



            }



        }

    }

}