using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tutorial.PhoneBook.Domain.Entities;

namespace Tutorial.PhoneBook.Application.Contracts
{
    public interface IDataBaseService
    {
        int DBSaveVhanges();
        Task<int> DBSaveVhangesAsync(CancellationToken cancellationToken=default);
        DbSet<User> Users { get; set; }
        DbSet<PhoneNumber> phoneNumbers { get; set; }
        DbSet<PhoneNumberType> phoneNumberTypes { get; set; }


    }
}
