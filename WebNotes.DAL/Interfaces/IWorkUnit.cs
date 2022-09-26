using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebNotes.DAL.Entities;

namespace WebNotes.DAL.Interfaces
{
    public interface IWorkUnit
    {
        IRepository<Note> Notes { get; }
        IRepository<User> Users { get; }
        IRepository<Topic> Topics { get; }

        void Save();
    }
}
