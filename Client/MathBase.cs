


public class MathBase:ComponentBase{
    protected string InputString

    protected string OutputString

    protected void DoProcessing()

    {
   
        double num = double.Parse(InputString);

        num = num * num;

        OutputString = num.ToString();

     }

}