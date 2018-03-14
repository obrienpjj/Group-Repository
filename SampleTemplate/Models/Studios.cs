using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Web;
using System.Threading.Tasks;

namespace StudioBookingApp.Models
{
    public class Studios : ICollection<Studio>
    {
        //property
        private List<Studio> Studiolist;

        //Constructor
        public Studios()
        {
            Studiolist = new List<Studio>();
        }

        #region Interface Properties

        public int Count { get; }

        public bool IsReadOnly
        {
            get { return false; }
        }

        #endregion

        #region Interface Methods

        public void Add(Studio studio)
        {
            Studiolist.Add(studio);
        }

        public void Clear()
        {
            Studiolist.Clear();
        }

        public bool Contains(Studio studio)
        {
            return Studiolist.Contains(studio);
        }

        public bool Remove(Studio studio)
        {
            return Studiolist.Remove(studio);
        }

        public void CopyTo(Studio[] array, int index)
        {
            Studiolist.CopyTo(array, index);
        }

        public IEnumerator<Studio> GetEnumerator()
        {
            return Studiolist.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return Studiolist.GetEnumerator();
        }

        #endregion

        #region Studios Methods

        public bool Remove(string studioID)
        {
            bool flag = false;
            for (int i = 0; i < Studiolist.Count && flag == false; i++ )
            {
                if (Studiolist[i].StudioID == studioID)
                {
                    Studiolist.Remove(Studiolist[i]);
                    flag = true;
                }
            }
            return flag;
        }

        #endregion
    }
}