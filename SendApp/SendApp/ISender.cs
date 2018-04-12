namespace SendApp
{
    public interface ISender
    {
        bool Send(string number, string message, int count);
    }

}
