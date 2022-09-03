class Demo<T>
{
    public void Pop(T x,T y)
    {
        dynamic sum = 0;
        dynamic p = x;
        dynamic q = y;
        sum = p + q;
        System.Console.WriteLine(sum);
    }
}
class Show
{
    static void Main()
    {
        Demo<int> d = new Demo<int>
            d.Pop(3, 4);
    }
}