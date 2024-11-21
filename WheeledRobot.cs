public class WheeledRobot
{
  private List<string> names;

  public WheeledRobot(List<string> test)
  {
    names = test;
  }

  public void resetNames()
  {
    names = [];
  }

  public void addName(string name)
  {
    names.Add(name);
  }
  public void printNames()
  {
    names.ForEach(Console.WriteLine);
  }
}
