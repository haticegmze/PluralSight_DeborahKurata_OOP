using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM_BL
{
    public enum EntityStateOption
    {
        active,
        deleted
    }
    public abstract class EntityBase
    { 
        
        public bool HasChange { get; set; }
        public bool IsNew { get; set; }
        public bool IsValid => Validate();
        public EntityStateOption EntityState { get; set; }
        public abstract bool Validate();
        
    }
}
