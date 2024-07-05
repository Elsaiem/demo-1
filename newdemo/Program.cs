using newdemo;

namespace demo_session
{
    internal class Program
    {
        #region functionss
        public static void printshape( int count=10,string pattern="*//*")
        {
            
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine(pattern);
            }


        }
        static void swap(int i, int j)
        {
            int temp = i;
            i = j;
            j = temp;
        }
        static void swapByref(ref int i,ref int j)
        {
            int temp = i;
            i = j;
            j = temp;
        }
        static int SumArray(params int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++) sum += array[i];
            return sum;

        
        }
        static void SumMul(int x,int y,out int sum,out int mul)
        {
            sum = x + y;
            mul = x*y;
        }


        #endregion


        static void Main(string[] args)
        {
            #region casting [Boxing-unboxing]
            ////boxing =>casting from value type to reference type
            ////Unboxing =>casting from refernce type to value type
            //object q1;
            //q1 = "Ahmed";//from value type to reference
            //q1 = 2;//from reference to value
            #endregion
            #region Ex02
            //int x = 10;
            //object y;
            //y = x; //Boxing safe casting

            //object z = 10 ;
            //int d = (int) z;//Unboxing casting[unsave casting]


            #endregion
            #region Nullable type
            ////Null as a value is valid only with reference type
            //int? y = 10;//in this case is allow to carry null 
            //y = null;
            //// nullable type in reference type
            //string m = "Hi";
            //m = null!;//null forgivness operator
            #region ex01


            //Nullable<int> x = null!;//not usable alot
            //decimal? num01;
            // decimal num02;
            //num02 = num01;//error
            //int x = 10;
            //int? y = (int?)x;//safe casting
            #endregion
            #region ex02


            //int? numm01 = null;
            //int num02 = (int)numm01;//explicit casting
            ////unsafe casting
            #endregion
            #region ex03


            int? k = null;
            int l;
            ////////////////////////////////
            if (k.HasValue) l = k.Value; else l = 0;
            //////////////////////
            l = k != null ? k.Value : 0; ;
            l = k.HasValue ? k.Value : 0;
            #endregion
            #endregion
            #region Null propagation Operator
            #region Ex
            //int[]? numbers = default;
            //for (int i = 0; (numbers != null) && (i < numbers.Length); i++)
            //    Console.WriteLine(numbers[i]);
            //for (int i = 0; (i < numbers?.Length); i++)
            //    Console.WriteLine(numbers[i]);
            //if (numbers != null) {

            //    for (int i = 0;(i < numbers.Length); i++)
            //        Console.WriteLine(numbers[i]);

            //}
            //int leng = numbers?.Length ?? 0;
            //Employee emp1=new Employee();
            //emp1.Department = new Department();
            //emp1.Department.name = "sales";
            //Console.WriteLine(emp1?.Department?.name);



            #endregion












            #endregion
            #region Functions
            //int count =10;
            //string pattern = "*--*";
            //printshape();
            // /n=new line
            // /t= tab
            #region passing value type parameters
            //int a = 10;
            //int b = 20;
            //swap(a, b);
            //Console.WriteLine(a);
            //Console.WriteLine(b);




            #endregion
            #region passing references type parameters
            //int[] arr = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //    int sum= SumArray(arr);






            #endregion

            #region passinng refernces type by references
            // int[] arr = { 0, 1, 2, 5, 6, 8 };
            //int sum= SumArray(ref arr);




            #endregion

            #region passing by out
            //int a = 10, y = 20, summ=0, mul;
            //SumMul(y, a,out summ,out mul);
            //Console.WriteLine(summ);
            //Console.WriteLine(mul);


            #endregion

            #region params
            int[] num = { 0, 1, 2, 3, 5, 8, 9 };
            int res = SumArray(0, 1, 2, 3, 5, 8, 9);



            #endregion

            #endregion





        }
    }
}
