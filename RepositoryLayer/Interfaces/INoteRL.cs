﻿using CommonLayer.User;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryLayer.Interfaces
{
    public interface INoteRL
    {
        void AddNote(int userId, NoteModel noteModel);
    }
}
