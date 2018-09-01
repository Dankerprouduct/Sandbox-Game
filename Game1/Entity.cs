using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics; 

namespace Game1
{
    public class Entity
    {
        static int nextAvailibleID = 0; 
        int id;

        public void SetID(int value) => id = value;

        public Entity()
        {

        }

        public virtual void Update()
        {
              
        }

        public virtual void Draw(SpriteBatch spriteBatch)
        {

        }

    }
}
