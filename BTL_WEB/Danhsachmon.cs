using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BTL_WEB
{
    public class Danhsachmon
    {
        int id;
        string img;
        string des;
        string type;
        string detail;
        string url;
        string video;
        //DateTime ngaydang;


        public int ID { get => id; set => id = value; }
        public string Img { get => img; set => img = value; }
        public string Des { get => des; set => des = value; }
        public string Type { get => type; set => type = value; }
        public string Detail { get => detail; set => detail = value; }
        public string Url { get => url; set => url = value; }
        public string Video { get => video; set => video = value; }
        //public DateTime Datend { get => ngaydang; set => ngaydang = value; }


        public Danhsachmon()
        {

        }
        public Danhsachmon(int id, string img, string des, string type, string detail, string url, string video) //DateTime nd
        {
            this.ID = id;
            this.Img = img;
            this.Des = des;
            this.Type = type;
            this.Detail = detail;
            this.Url = url;
            this.Video = video;
            //this.Datend = nd;
        }
    }
}