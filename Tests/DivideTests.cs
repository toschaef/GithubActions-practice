namespace GithubActionsLab;

[TestClass]
public class Division
{
    [TestMethod]
    public void Divide_Valid_Patino()
    {
        Assert.AreEqual(2, Program.Divide("6", "3"));
        Assert.AreEqual(0.5, Program.Divide("1", "2"));
    }

    [TestMethod]
    public void Divide_Invalid_Patino()
    {
        Assert.ThrowsException<FormatException>(() => Program.Divide("a", "2"));
        Assert.ThrowsException<FormatException>(() => Program.Divide("3", "b"));
    }

    [TestMethod]
    public void Divide_Null_Patino()
    {
        Assert.ThrowsException<ArgumentNullException>(() => Program.Divide(null, "2"));
        Assert.ThrowsException<ArgumentNullException>(() => Program.Divide("2", null));
    }
}
