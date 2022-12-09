class Program
{

    static void CheckInput(Stack<char> InputList)
    {

        char InputRem;
        InputRem = char.Parse(Console.ReadLine());
        
            if(InputRem == '(' || InputRem == ')')
            {
                InputList.Push(InputRem);
                CheckInput(InputList);
            }
            else
            {
                
                int range = 0;
                int half = InputList.GetLength()/2;
                if(InputList.GetLength()>0)
                {
                
               
            

                
                    while(InputList.GetLength() >= half)
                    {
                        
                      while(range > InputList.GetLength())
                      {
                            if(InputList.Get(range) == ')')
                            {
                                range++;
                            
                                if(InputList.Get(range) =='(')
                                {
                                
                                    InputList.Pop();
                                    range = 0;
                                
                                 }
                                else
                                {
                                    range++; 
                                                  
                                }
                            }
                            else if(InputList.Get(range) == '(')
                            {
                            range++;
                            
                                if(InputList.Get(range) =='(')
                                {
                                
                                    InputList.Pop();
                                    range = 0;
                                
                                }
                                else
                                {
                                    range++; 
                                                     
                                }
                        }
                        else{
                            Console.WriteLine("Invalid");
                            break;
                        }
                      }
 
                    }
                Console.WriteLine("Valid");
                    
                  

                }
            }
                
        
        
       
        // while(InputList.GetLength()>0){
        //     if(InputList.GetLength()==1 ||InputList.GetLength()==3||InputList.GetLength()==5||InputList.GetLength()==7||InputList.GetLength()==9){
        //        Console.WriteLine("Invalid");
        //        break;
        //     }
        //     else if(InputList.GetLength()-range == ')'){
        //         range++;
        //         if(InputList.GetLength()-range =='('){
        //           InputList.Pop(range);
        //         }
        //         else{
                    
        //         }

        //     }
        //     else{
        //         Console.WriteLine("Valid");
        //         break;
        //     }
        // }

        

  
    }



    static void Main(string[] args)
    {
        Console.WriteLine("Input ( or )");
        Stack<char> InputList = new Stack<char>();
        CheckInput(InputList);


    }
}