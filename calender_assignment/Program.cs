namespace calender_assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter month(Press 1 for Jan, 2 for Feb, 12 for Dec......)");
            int month = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter Year ");
            int year = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter Day of week(Press 1 for Mon, 2 for Tue, 7 for Sun......)");
            int day = Convert.ToInt16(Console.ReadLine());
            string line = "  ";
            Console.WriteLine(line);
            line = "";



            Console.WriteLine(" \t \t \t Calender  \n ");



            Console.WriteLine("S\tM\tTu\tW\tTh\tF\tS\n");



            switch (month)
            {
                case 1:
                    {
                        for (int i = 0; i < day; i++)
                        {
                            Console.Write("\t");
                        }
                        for (int i = 1; i <= 31; i++)
                        {
                            Console.Write(i + "\t");
                            if ((day + i) % 7 == 0)
                                Console.WriteLine("\n");
                        }
                        break;
                    }
                case 2:
                    {
                        if ((year % 4 == 0) && (year % 100 != 0))
                        {
                            for (int i = 0; i < day; i++)
                            {
                                Console.Write("\t");
                            }
                            for (int i = 1; i <= 29; i++)
                            {
                                Console.Write(i + "\t");
                                if ((day + i) % 7 == 0)
                                    Console.WriteLine("\n");
                            }
                        }
                        else
                        {
                            for (int i = 0; i < day; i++)
                            {
                                Console.Write("\t");
                            }
                            for (int i = 1; i <= 28; i++)
                            {
                                Console.Write(i + "\t");
                                if ((day + i) % 7 == 0)
                                    Console.WriteLine("\n");
                            }
                        }
                        break;

                    }
                case 3:
                    {
                        for (int i = 0; i < day; i++)
                        {
                            Console.Write("\t");
                        }
                        for (int i = 1; i <= 31; i++)
                        {
                            Console.Write(i + "\t");
                            if ((day + i) % 7 == 0)
                                Console.WriteLine("\n");
                        }
                        break;
                    }
                case 4:
                    {
                        int april = 30;
                        for (int i = 1; i <= day; i++)
                        {
                            Console.Write("\t");
                        }
                        for (int j = 1; j <= april; j++)
                        {
                            Console.Write($"{j}\t");
                            if ((day + j) % 7 == 0)
                            {
                                Console.WriteLine("\n");
                            }



                        }
                        break;
                    }
                case 5:
                    {
                        int may = 31;
                        for (int i = 1; i <= day; i++)
                        {
                            Console.Write("\t");
                        }
                        for (int j = 1; j <= may; j++)
                        {
                            Console.Write($"{j}\t");
                            if ((day + j) % 7 == 0)
                            {
                                Console.WriteLine("\n");
                            }



                        }
                        break;
                    }

                case 6:
                    {
                        
                    
                        int june = 30;
                        for (int i = 1; i <= day; i++)
                        {
                            Console.Write("\t");
                        }
                        for (int j = 1; j <= june; j++)
                        {
                            Console.Write($"{j}\t");
                            if ((day + j) % 7 == 0)
                            {
                                Console.WriteLine("\n");
                            }



                        }
                        break;
                    }
                case 7:
                    {
                        int july = 31;
                        for (int i = 1; i <= day; i++)
                        {
                            Console.Write("\t");
                        }
                        for (int j = 1; j <= july; j++)
                        {
                            Console.Write($"{j}\t");
                            if ((day + j) % 7 == 0)
                            {
                                Console.WriteLine("\n");
                            }



                        }
                        break;
                    }

                case 8:
                    {
                        
                    
                        int august = 31;
                        for (int i = 1; i <= day; i++)
                        {
                            Console.Write("\t");
                        }
                        for (int j = 1; j <= august; j++)
                        {
                            Console.Write($"{j}\t");
                            if ((day + j) % 7 == 0)
                            {
                                Console.WriteLine("\n");
                            }



                        }
                        break;
                    }
                case 9:
                    {
                        int sep = 30;
                        for (int i = 1; i <= day; i++)
                        {
                            Console.Write("\t");
                        }
                        for (int j = 1; j <= sep; j++)
                        {
                            Console.Write($"{j}\t");
                            if ((day + j) % 7 == 0)
                            {
                                Console.WriteLine("\n");
                            }



                        }
                        break;
                    }

                    

                    case 10:
                    {
                        int oct = 31;
                        for (int i = 1; i <= day; i++)
                        {
                            Console.Write("/t");
                        }
                        for (int j = 1; j <= oct; j++)
                        {
                            Console.Write($"{j}\t");
                            if ((day + j) % 7 == 0)
                            {
                                Console.WriteLine("\n");
                            }



                        }
                        break;
                    }
                case 11:
                    {
                        int nov = 30;
                        for (int i = 1; i <= day; i++)
                        {
                            Console.Write("\t");
                        }
                        for (int j = 1; j <= nov; j++)
                        {
                            Console.Write($"{j}\t");
                            if ((day + j) % 7 == 0)
                            {
                                Console.WriteLine("\n");
                            }



                        }
                        break;
                    }
                case 12:
                    {
                        int dec = 31;
                        for (int i = 1; i <= day; i++)
                        {
                            Console.Write("\t");
                        }
                        for (int j = 1; j <= dec; j++)
                        {
                            Console.Write($"{j}\t");
                            if ((day + j) % 7 == 0)
                            {
                                Console.WriteLine("\n");
                            }



                        }
                        break;
                    }



            }




            }
        }   }
