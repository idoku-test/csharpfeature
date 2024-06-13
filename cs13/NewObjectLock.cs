public class NewObjectLock{
private static Lock _lock = new Lock();

public static void Lock(){
 using(_lock.EnterScope())
    {
       Console.WriteLine("Inside the lock.");
    }
   }
}