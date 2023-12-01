namespace AdventOfCode1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool end = false;
            string input;
            int peekInt;
            string tempStr;
            string tempStr3 = "";
            string tempStr4 = "";
            string tempStr5 = "";
            int first;
            bool found;
            int last;
            int count;
            string resultStr;
            int resultInt = 0;

            string fileName = @"..\puzzleinput.txt";
            using (StreamReader CF = new StreamReader(fileName))
            
                do
                {
                    count = 0;
                    found = false;
                    tempStr3 = "";
                    tempStr4 = "";
                    tempStr5 = "";

                    input = CF.ReadLine();


                    //if (input.Length == null)
                    //{
                    //    end = true;
                    //}
                    //else
                    
                        do
                        {
                            tempStr = input[count].ToString();
                            if (int.TryParse(tempStr, out first))
                            {
                                first = int.Parse(tempStr);

                                found = true;
                            }

                            if(found == false)
                            {
                                tempStr = "";
                                for (int i = 0; i <= 4; i++)
                                {
                                    tempStr = tempStr + input[count + i].ToString();
                                }

                                for(int i = 0; i <= 2;i++)
                                {
                                    tempStr3 = tempStr3 + tempStr[i];
                                }
                                
                                switch (tempStr3)
                                {
                                    case "one":
                                        found = true;
                                        first = 1;
                                        break;

                                    case "two": 
                                        found = true;
                                        first = 2;
                                        break;

                                    case "six":
                                        found = true;
                                        first = 6; break;
                                    default: found = false; break;

                                }

                                
                            }

                        if (found == false)
                        {
                            tempStr4 = "";
                            for (int i = 0; i <= 3; i++)
                            {
                                tempStr4 = tempStr4 + tempStr[i];
                            }


                            switch (tempStr4)
                            {
                                case "four":
                                    found = true;
                                    first = 4;
                                    break;

                                case "five":

                                default: found = false; break;
                            }
                        }
                            

                           

                            count++;
                        } while (found == false);







                        found = false;
                        count = input.Length - 1;
                          do
                         {
                            tempStr = input[count].ToString();
                            if (int.TryParse(tempStr, out last))
                            {
                                last = int.Parse(tempStr);
                                found = true;
                            }

                            count--;
                           } while (found == false);
                        resultStr = first.ToString() + last.ToString();
                        resultInt += int.Parse(resultStr);
                        Console.WriteLine(resultInt);
                      
                    
                } while (end == false);
            
            Console.ReadKey();

        }
    }
}
