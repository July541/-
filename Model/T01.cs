using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Serializable]
    public partial class T01
    {
        public T01()
        { }
        #region Model
        private int _f0101;
        private string _f0102;
        private int? _f0103;
        private DateTime? _f0104;
        private string _f0105;
        private string _f0106;
        private string _f0107;
        private string _f0108;

        public int F0101
        {
            set { _f0101 = value; }
            get { return _f0101; }
        }

        public string F0102
        {
            set { _f0102 = value; }
            get { return _f0102; }
        }

        public int? F0103
        {
            set { _f0103 = value; }
            get { return _f0103; }
        }

        public DateTime? F0104
        {
            set { _f0104 = value; }
            get { return _f0104; }
        }

        public string F0105
        {
            set { _f0105 = value; }
            get { return _f0105; }
        }

        public string F0106
        {
            set { _f0106 = value; }
            get { return _f0106; }
        }

        public string F0107
        {
            set { _f0107 = value; }
            get { return _f0107; }
        }

        public string F0108
        {
            set { _f0108 = value; }
            get { return _f0108; }
        }
        #endregion Model
    }
}
