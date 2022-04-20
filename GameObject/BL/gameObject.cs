using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using GameObject.UI;


namespace GameObject.BL
{
    class gameObject
    {
        public char[,] Shape;
        public Point StartingPoint;
        public Boundary Premises;
        public string Direction;
        public gameObject()
        {
            Shape = new char[,] { { '-', '-', '-' }, { '-', '-', '-' }, { '-', '-', '-' }, { '-', '-', '-' }, { '-', '-', '-' } };
            StartingPoint = new Point();
            Premises = new Boundary();
            Direction = "LeftToRight";

        }
        public gameObject(char [,] shape,Point StartingPoint)
        {
            this.Shape = shape;
            this.StartingPoint = StartingPoint;
            Premises = new Boundary();
            Direction = "LeftToRight";


        }
        public gameObject(char[,] shape, Point StartingPoint,Boundary Premises,string Direction)
        {
            this.Shape = shape;
            this.StartingPoint = StartingPoint;
            this.Premises = Premises;
            this.Direction = Direction;

        }
        public void Erase()
        {
            Console.Clear();
        }
        public void DrawShape()
        {
            for(int i = 0; i <Shape.GetLength(0) ; i++)
            {
                

                for (int j = 0; j < Shape.GetLength(1); j++)
                {
                    Console.SetCursorPosition(StartingPoint.x+j, StartingPoint.y+i);
                    GameUI.showOnConsole(Shape[i, j]);
                }
                GameUI.showOnConsole("\n");

            }
        }
        public void Move()
        {
            int s = StartingPoint.x;
            if (Direction == "LefttoRight") { 

                while (s < Premises.TopRight.x)
                {
                    
                    for (int i = 0; i < Shape.GetLength(0); i++)
                    {
                        // to draw at every place nect place
                        for (int j = 0; j < Shape.GetLength(1); j++)
                        {
                            Console.SetCursorPosition(s + j, StartingPoint.y + i);
                            GameUI.showOnConsole(Shape[i, j]);
                        }
                        GameUI.showOnConsole("\n");

                    }
                    Thread.Sleep(30);
                    for (int i = 0; i < Shape.GetLength(0); i++)
                    {
                        //for removing previously placed

                        for (int j = 0; j < Shape.GetLength(1); j++)
                        {
                            Console.SetCursorPosition(s + j, StartingPoint.y + i);
                            GameUI.showOnConsole(' ');
                        }
                        GameUI.showOnConsole("\n");

                    }
                    s++;
                }

            }
            else if(Direction == "RighttoLeft")
            {
                int r = StartingPoint.x;

                while (r > Premises.TopLeft.x)
                {
                    for (int i = 0; i < Shape.GetLength(0); i++)
                    {
                        // to draw at every place nect place


                        for (int j = 0; j < Shape.GetLength(1); j++)
                        {
                            Console.SetCursorPosition(r + j, StartingPoint.y + i);
                            GameUI.showOnConsole(Shape[i, j]);
                        }
                        GameUI.showOnConsole("\n");

                    }
                    Thread.Sleep(20);
                    for (int i = 0; i < Shape.GetLength(0); i++)
                    {
                        // to draw at every place nect place


                        for (int j = 0; j < Shape.GetLength(1); j++)
                        {
                            Console.SetCursorPosition(r + j, StartingPoint.y + i);
                            GameUI.showOnConsole(' ');
                        }
                        GameUI.showOnConsole("\n");

                    }
                    r--;
                }
            }
            else if (Direction == "Patrol")
            {
                

                int r = StartingPoint.x;

                while (r > Premises.TopLeft.x)
                {
                    for (int i = 0; i < Shape.GetLength(0); i++)
                    {
                        // to draw at every place nect place


                        for (int j = 0; j < Shape.GetLength(1); j++)
                        {
                            Console.SetCursorPosition(r + j, StartingPoint.y + i);
                            GameUI.showOnConsole(Shape[i, j]);
                        }
                        GameUI.showOnConsole("\n");

                    }
                    Thread.Sleep(20);
                    for (int i = 0; i < Shape.GetLength(0); i++)
                    {
                        // to draw at every place nect place


                        for (int j = 0; j < Shape.GetLength(1); j++)
                        {
                            Console.SetCursorPosition(r + j, StartingPoint.y + i);
                            GameUI.showOnConsole(' ');
                        }
                        GameUI.showOnConsole("\n");

                    }
                    r--;
                }
                StartingPoint.x = 0;
                r = StartingPoint.x;


                while (r < Premises.TopRight.x)
                {

                    for (int i = 0; i < Shape.GetLength(0); i++)
                    {
                        // to draw at every place nect place
                        for (int j = 0; j < Shape.GetLength(1); j++)
                        {
                            Console.SetCursorPosition(r + j, StartingPoint.y + i);
                            GameUI.showOnConsole(Shape[i, j]);
                        }
                        GameUI.showOnConsole("\n");

                    }
                    Thread.Sleep(30);
                    for (int i = 0; i < Shape.GetLength(0); i++)
                    {
                        //for removing previously placed

                        for (int j = 0; j < Shape.GetLength(1); j++)
                        {
                            Console.SetCursorPosition(r + j, StartingPoint.y + i);
                            GameUI.showOnConsole(' ');
                        }
                        GameUI.showOnConsole("\n");

                    }
                    r++;
                }

            }
            else if (Direction == "Projectile")
            {
                int str = StartingPoint.y;
                int controler = 0;
                while (controler < 5)//upward controller
                {
                    for (int i = 0; i < Shape.GetLength(0); i++)
                    {
                        // to draw at every place nect place to go to upward


                        for (int j = 0; j < Shape.GetLength(1); j++)
                        {
                            Console.SetCursorPosition(StartingPoint.x + j, str+ i);
                            GameUI.showOnConsole(Shape[i, j]);
                        }
                        GameUI.showOnConsole("\n");

                    }
                    Thread.Sleep(40);
                    for (int i = 0; i < Shape.GetLength(0); i++)
                    {
                        // to draw at every place nect place space


                        for (int j = 0; j < Shape.GetLength(1); j++)
                        {
                            Console.SetCursorPosition(StartingPoint.x + j, str + i);
                            GameUI.showOnConsole(' ');
                        }
                        GameUI.showOnConsole("\n");

                    }
                    str--;
                    controler++;
                    StartingPoint.y = str-1;

                    
                }
                str = StartingPoint.x;
                controler = 0;
                while(controler < 3)//rightward Controller
                {
                    for (int i = 0; i < Shape.GetLength(0); i++)
                    {
                        // to draw at every place nect place to go to upward

                        for (int j = 0; j < Shape.GetLength(1); j++)
                        {
                            Console.SetCursorPosition(str + j, StartingPoint.y + i);
                            GameUI.showOnConsole(Shape[i, j]);
                        }
                        GameUI.showOnConsole("\n");

                    }
                    Thread.Sleep(40);
                    for (int i = 0; i < Shape.GetLength(0); i++)
                    {
                        // to draw at every place nect place to go to upward

                        for (int j = 0; j < Shape.GetLength(1); j++)
                        {
                            Console.SetCursorPosition(str + j, StartingPoint.y + i);
                            GameUI.showOnConsole(' ');
                        }
                        GameUI.showOnConsole("\n");

                    }
                    str++;
                    controler++;
                    StartingPoint.x = str;
                }
                str = StartingPoint.y;
                controler = 0;
                while (controler < 4)//downward controller
                {
                    for (int i = 0; i < Shape.GetLength(0); i++)
                    {
                        // to draw at every place nect place to go to upward


                        for (int j = 0; j < Shape.GetLength(1); j++)
                        {
                            Console.SetCursorPosition(StartingPoint.x + j, str + i);
                            GameUI.showOnConsole(Shape[i, j]);
                        }
                        GameUI.showOnConsole("\n");

                    }
                    Thread.Sleep(40);
                    for (int i = 0; i < Shape.GetLength(0); i++)
                    {
                        // to draw at every place nect place space


                        for (int j = 0; j < Shape.GetLength(1); j++)
                        {
                            Console.SetCursorPosition(StartingPoint.x + j, str + i);
                            GameUI.showOnConsole(' ');
                        }
                        GameUI.showOnConsole("\n");

                    }
                    str++;
                    controler++;


                }
            }
        }
    }
}
