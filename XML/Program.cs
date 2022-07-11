using System;

namespace XML
{
    /// <summary>
    /// Программа запрашивает имя и возоаст,в зависимости отвозраста меняет приветствие
    /// </summary>
     class Program
    {
        /// <summary>
        /// принимает инициализированную переменную"Как звать?"
        /// возвращает введеное имя
        /// </summary>
        /// <param>string AsName = "Как звать?"</param>
        /// <returns> return myAnswer</returns>
        static string MyAsk(string Name)
        {
            
            Console.WriteLine(Name);
            string myAnswer = Console.ReadLine();
            return myAnswer;
                
        }
        /// <summary>
        /// Переводит введенный возраст в цедочисленный тип
        /// </summary>
        /// <param> принимает резултат функции AnswerAge - return userage</param>
        /// <returns> возврвщает - return res</returns>
        static int myConvert(string myText)
        {
            int res = 0;
            
            try
            {
                Convert.ToInt32(myText);
            }
            catch (Exception)
            {


            }
            return res;
        }
        /// <summary>
        /// Принимает инициализированную переменную string AskAge
        /// возвращает введенное число
        /// </summary>
        /// <param name="myAskAge">"Сколько лет?"</param>
        /// <returns>введенное число (string)</returns>
        static int AnswerAge(string myAskAge)
       {
            Console.WriteLine(myAskAge);
           int userage = 0;
            
           
          
                    userage = myConvert(Console.ReadLine());
               
            
           
            return userage;


        }
        /// <summary>
        /// принимает 4 параметра (имя , возраст , и два способа приветствия)
        /// Если возраст меньше 18 , то использует параметр h(привет) , иначе H(Здравствуйте)
        ///
        /// </summary>
        /// <param name="N">Имя</param>
        /// <param name="A">Возраст</param>
        /// <param name="h">Привет</param>
        /// <param name="H">здравствуйте</param>
        static void myhello(string N,int A,string h,string H)
        {

            if (A < 18)
            {
                Console.WriteLine(h);
            }
            else
            {
                Console.WriteLine(H);
            }
        }
        

        static void Main(string[] args)
            

        {
           
           
          
           
            string AsName = "Как звать?";
            string AskAge = "Сколько лет?";

            string UserName = MyAsk(AsName);
           
           string Hi = "Привет";
           string Hello = "Здравствуйте ";
            int UserAge = AnswerAge(AskAge);
           // string age = Console.ReadLine();
            //myConvert(age);
            myhello(UserName,UserAge,Hi,Hello);
            Console.ReadKey();
        }
    }
}
