using System;
using System.Collections.Generic;

namespace IntroSQL
{
    public interface IDepartamentRepository
    {
        IEnumerable<Departaments> GetAllDepartaments();
    }
}
