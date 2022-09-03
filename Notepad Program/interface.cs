interface M1
{
   public abstract void run();
    void clean();
}
class Demo : M1
{
    public void run()
    {
        System.Console.WriteLine("hello kitty");
    }
    public void clean()
    {
        System.Console.WriteLine("see you kitty");
    }
}
class Shut
{
    static void Main()
    {
        Demo d = new Demo();
        d.run();
    }

}