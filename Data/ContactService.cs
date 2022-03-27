using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Zenon___Contact_Management_System.Data
{
    public class ContactService
    {
        //Create a readonly property
        private readonly AppDBContext _appDBContext;

        //Create a constructor
        public ContactService(AppDBContext appDBContext)
        {
            _appDBContext = appDBContext;
        }

        //Get all contacts
        public async Task<List<Contact>> GetAllContactsAsync()
        {
            return await _appDBContext.Contacts.ToListAsync();
        }

        //Add contact
        public async Task<bool> AddContactAsync(Contact contact)
        {
            await _appDBContext.Contacts.AddAsync(contact);
            await _appDBContext.SaveChangesAsync();
            return true;
        }

        //Get contact by Id
        public async Task<Contact> GetContactAsync(int Id)
        {
            Contact contact = await _appDBContext.Contacts.FirstOrDefaultAsync(c => c.Id.Equals(Id));
            return contact;
        }

        //Update contact
        public async Task<bool> UpdateContactAsync(Contact contact)
        {
            _appDBContext.Contacts.Update(contact);
            await _appDBContext.SaveChangesAsync();
            return true;
        }

        //Delete contact
        public async Task<bool> DeleteContactAsync(Contact contact)
        {
            _appDBContext.Remove(contact);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
    }
}