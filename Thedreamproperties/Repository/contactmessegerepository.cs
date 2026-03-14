using Thedreamproperties.Context;

namespace Thedreamproperties.Repository
{
    public class contactmessegerepository : Icontactmessegerepository
    {
        private readonly Appdbcontext _dbcontext;
        public contactmessegerepository(Appdbcontext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public async  Task savacontactmessege(string name, string email, string subject, string messege)
        {
            await _dbcontext.SaveContactmessegeasync(name,email,subject,messege);
        }
    }
}
