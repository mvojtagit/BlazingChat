namespace BlazingChat.Shared.Models
{
    public class Contact
    {
        public Contact()
        {

        }

        public Contact(int contactId, string strFirstName, string strLastName)
        {
            this.ContactId=contactId;
            this.FirstName=strFirstName;
            this.LastName=strLastName;
        }
        
        public int ContactId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }


    }
}