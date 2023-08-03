using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace IKYS.Domain.Abstract
{
    public class PersonelBase
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string City { get; set; }
        public int PhoneNumber { get; set; }
        public int BirthDay { get; set; }
        public Gender Gender { get; set; }

    }
    public enum Gender 
    {
        Male=1,
        Female=2
    }

}
