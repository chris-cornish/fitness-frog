using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessFrog.Core.Domain.Data
{
    /// <summary>
    /// Public interface implemented by all EntityConfiguration derived classes.
    /// </summary>
    public interface IEntityConfiguration
    {
        string TableName { get; }
        Type EntityType { get; }
    }
}
