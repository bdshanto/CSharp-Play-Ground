namespace C_9GenericsApp
{
  public class Stack
  {
    private double[] Numbers;
    private int CurrentIndex = -1;
    public Stack() => Numbers = new double[10];
    public int Count => CurrentIndex + 1;


    public void Add(double item) => Numbers[++CurrentIndex] = item;
    public double Pop() => Numbers[CurrentIndex--];
  }
}