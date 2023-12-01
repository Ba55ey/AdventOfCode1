namespace AdventOfCode1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool end = false;
            string input;
            string tempStr;
            int first;
            bool found;
            int last;
            int count;
            string resultStr;
            int resultInt = 0;

            string fileName = @"..\puzzleinput.txt";
            using (StreamReader CF = new StreamReader(fileName))
            {
                do
                {
                    count = 0;
                    found = false;
                    // Console.WriteLine("Input:");
                    //input = Console.ReadLine();
                   

                    input = CF.ReadLine();


                    //if (input.Length == null)
                    //{
                    //    end = true;
                    //}
                    //else
                    {
                        do
                        {

                            tempStr = input[count].ToString();
                            if (int.TryParse(tempStr, out first))
                            {
                                first = int.Parse(tempStr);
                                found = true;
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
                      
                    }
                } while (end == false);
            }
            Console.ReadKey();

        }
    }
}