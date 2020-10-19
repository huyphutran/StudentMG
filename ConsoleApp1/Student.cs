using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace SingleLinkedListStudentManagment
{       

    public class Student
    {
        private int _mssv;
        private string _ten;
        private int _tuoi;
        private string _gioitinh;
        private int _khoa;
        private int v1;
        private string v2;
        private string v3;
        private int v4;

        public Student(int mssv, string ten, int tuoi, string gioitinh, int khoa) {
            this._mssv = mssv;
            this._ten = ten;
            this._tuoi = tuoi;
            this._gioitinh = gioitinh;
            this._khoa = khoa;
        }

        public string showDetail()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("MSSV :");
            sb.Append(_mssv);
            sb.Append("\n Ho va Ten:");
            sb.Append(_ten);
            sb.Append("\n Tuoi:");
            sb.Append(_tuoi);
            sb.Append("\n GioiTinh:");
            sb.Append(_gioitinh);
            sb.Append("\n NienKhoa:");
            sb.Append(_khoa);

            return sb.ToString();
        }
        public int Mssv
        {
            get
            {
                return _mssv;
            }

            set
            {
                _mssv = value;
            }
        }
        public string Ten
        {
            get
            {
                return _ten;
            }

            set
            {
                _ten = value;
            }
        }
        public string GioiTinh
        {
            get
            {
                return _gioitinh;
            }

            set
            {
                _gioitinh = value;
            }
        }
        public int Tuoi
        {
            get
            {
                return _tuoi;
            }

            set
            {
                _tuoi = value;
            }
        }

        public int Khoa
        {
            get
            {
                return _khoa;
            }

            set
            {
                _khoa = value;
            }
        }
        public Student ()
        {

        }
    }
}

