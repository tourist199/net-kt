using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppG4.Model
{
    public class SinhvienBEAN
    {
        int id { get; set; }
        string hoten { get; set; }
        bool gioitinh { get; set; }
        DateTime ngaysinh { get; set; }

        public SinhvienBEAN(int id, string hoten, bool gioitinh, DateTime ngaysinh)
        {
            this.id = id;
            this.hoten = hoten;
            this.gioitinh = gioitinh;
            this.ngaysinh = ngaysinh;
        }
        public SinhvienBEAN(DataRow row)
        {
            this.id = Int16.Parse( row["id"].ToString());
            this.hoten = row["hoten"].ToString();
            this.gioitinh = bool.Parse( row["gioitinh"].ToString());
            this.ngaysinh = DateTime.Parse( row["ngaysinh"].ToString());
        }

    }
}

