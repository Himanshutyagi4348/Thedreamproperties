namespace Thedreamproperties.Repository
{
    public interface Icontactmessegerepository
    {
        Task savacontactmessege(string name,string email,string subject,string messege);
    }
}
