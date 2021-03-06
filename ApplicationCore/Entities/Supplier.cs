using Murimi.ApplicationCore.SharedKernel;

namespace Murimi.ApplicationCore.Entities
{
    public class Supplier : BaseEntity, IAggregateRoot
    {
        public string Name { get; private set; }

        public string Phone { get; private set; }

        public string Email { get; private set; }

        public string Website { get; private set; }

        public string ContactPerson { get; private set; }

        public string ContactPersonEmail { get; private set; }

        public string ContactPersonPhone { get; private set; }

        public Address BillingAddress { get; private set; }

        public Supplier(string name, string phone, string email, string website, string contactPerson, 
            string contactPersonEmail, string contactPersonPhone, Address billingAddress)
        {
            SetData(name, phone, email, website, contactPerson, contactPersonEmail, contactPersonPhone, billingAddress);
        }

        public void UpdateDetails(string name, string phone, string email, string website, string contactPerson,
            string contactPersonEmail, string contactPersonPhone, Address billingAddress)
        {
            SetData(name, phone, email, website, contactPerson, contactPersonEmail, contactPersonPhone, billingAddress);
        }

        private void SetData(string name, string phone, string email, string website, string contactPerson,
            string contactPersonEmail, string contactPersonPhone, Address billingAddress)
        {
            Guard.AgainstNullOrEmpty(name, nameof(name));
            Guard.AgainstNullOrEmpty(email, nameof(email));
            Guard.AgainstNullOrEmpty(contactPerson, nameof(contactPerson));
            Guard.AgainstNullOrEmpty(contactPersonEmail, nameof(contactPersonEmail));

            Name = name;
            Phone = phone;
            Email = email;
            Website = website;
            ContactPerson = contactPerson;
            ContactPersonEmail = contactPersonEmail;
            ContactPersonPhone = contactPersonPhone;
            BillingAddress = billingAddress;
        }
    }
}
