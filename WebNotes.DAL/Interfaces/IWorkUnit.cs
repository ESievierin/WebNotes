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
        INoteRepository Notes { get; }
        IUserRepository Users { get; }
        ITopicRepository Topics { get; }

        void Save();
    }
}
