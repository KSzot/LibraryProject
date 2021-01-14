using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInterface.Classes
{
    class EmailBuilder
    {
        private readonly Email email;
        public EmailBuilder(Email email) => this.email = email;
        public EmailBuilder From(string from)
        {
            email.From = from;
            return this;
        }
        public EmailBuilder To(string to)
        {
            email.To = to;
            return this;
        }
        public EmailBuilder Subject(string subject)
        {
            email.Subject = subject;
            return this;
        }
        public EmailBuilder Body(string body)
        {
            email.Body = body;
            return this;
        }
        
    }
}
