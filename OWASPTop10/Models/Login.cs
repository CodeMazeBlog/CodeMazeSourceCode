using System.ComponentModel.DataAnnotations;

namespace OWASPTop10.Models
{
    public class Login
    {
        public int ID { get; set; }

        public string Username { get; set; }

        [ShouldNotContainSingleQuotesValidation(ErrorMessage = "Cannot contain single quotes")]
        public string Password { get; set; }

        public string Message { get; set; }
    }

    public sealed class ShouldNotContainSingleQuotesValidation : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            return !value.ToString().Contains("'");
        }
    }
}
