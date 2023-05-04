using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace BTL_WEB
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            //Danh sách user đọc từ file
            string path = "listMember.xml";
            List<Member> list = new List<Member>();
            if (File.Exists(Server.MapPath(path)))
            {
                // Đọc file
                System.Xml.Serialization.XmlSerializer reader = new System.Xml.Serialization.XmlSerializer(typeof(List<Member>));
                StreamReader file = new StreamReader(Server.MapPath(path));

                list = (List<Member>)reader.Deserialize(file);
                list = list.OrderBy(Member => Member.ID).ToList();
                file.Close();
            }
            Application["dsmem"] = list;

            //Danh sách môn
            Application["dsmon"] = new List<Danhsachmon>();
            List<Danhsachmon> arr = new List<Danhsachmon>();
            arr.Add(new Danhsachmon() 
            { 
                ID = 1, 
                Img = "Img/pic2.png", 
                Des = "Thiết kế web", 
                Type = "môn chính", 
                Detail = "Tên miền (domain): tên miền chính là địa chỉ website. Website bắt buộc phải có tên miền. Tên miền có nhiều dạng như www.abc.com, www.abc.net hay www.abc.com.vn... Có những website không mua tên miền riêng mà dùng tên miền con (sub-domain) dạng www.abc.com/xyz hay www.xzy.abc.com (xzy là tên miền con của tên miền abc.com). Dạng tên miền con như vậy không phải tốn tiền mua mà trên nguyên tắc là website “mẹ” (tức www.abc. com) có thể “mở” hàng trăm, hàng nghìn tên miền con như thế. Chi phí trả cho một tên miền dạng www.abc.com khi mua trên mạng là khoảng 10 đô-la Mỹ/năm."
                + "<br/><br/>" +"Dịch vụ lưu trữ (hosting, hay host): muốn những trang web được hiện lên khi người ta truy cập vào website thì dữ liệu phải được lưu trữ trên một máy tính (máy chủ - server) luôn hoạt động và kết nối với mạng Internet, máy tính này chính là host server. Một host server có thể lưu trữ rất nhiều website cùng một lúc. Nếu máy tính này có sự cố bị tắt trong một thời điểm nào đó thì lúc đó không ai truy cập được những website lưu trữ trên máy tính đó. Tùy theo nhu cầu mà doanh nghiệp có thể chọn mua host với dung lượng 10MB (tức chứa được tối đa 10MB dữ liệu), 20MB, 50MB, 100MB hay nhiều hơn. Giá hosting hiện nay cũng rất thấp, chỉ từ vài chục nghìn đến một hai trăm nghìn đồng mỗi tháng, tùy theo cấu hình host và ngôn ngữ lập trình và cơ sở dữ liệu mà host hỗ trợ."
                + "<br/><br/>" +"Dung lượng host và dung lượng truyền (transfer): dung lượng host là số MB dành để chứa dữ liệu. Ví dụ host 100MB cho doanh nghiệp 100MB để chứa ﬁle, cơ sở dữ liệu, email... Dung lượng truyền của host là tổng số MB dữ liệu, ﬁle... truyền ra truyền vào (download, upload) máy chủ nơi host website trong mỗi tháng."
                + "<br/><br/>" +"Khi doanh nghiệp mua host cho website, cần ước tính dung lượng truyền theo công thức sau: Dung lượng truyền trong tháng (transfer/month) (GB) = số lượt truy cập website trong tháng x số trang bình quân mỗi lượt người xem x số KB mỗi trang web / 1.000.000 (đổi từ KB sang GB). Ví dụ: ước tính website của doanh nghiệp sẽ có khả năng đón 10.000 lượt người xem trong tháng, mỗi lượt người sẽ xem bình quân 10 trang, mỗi trang web nặng bình quân 100KB, vậy doanh nghiệp cần dung lượng truyền là (10.000 x 10 x 100)/1.000.000 = 10GB/tháng.", 
                Url = "https://tamnguyen.com.vn/khai-niem-co-ban-lien-quan-den-thiet-ke-web.html",
                Video = "https://www.youtube.com/embed/-Dwo-UOjDuw",
            });
            arr.Add(new Danhsachmon() { 
                ID = 2, 
                Img = "Img/pic3.png", 
                Des = "Client ", 
                Type = "môn chính",
                Detail = "Máy Client tổ chức giao tiếp với người dùng, server và môi trường bên ngoài tại trạm làm việc. Client tiếp nhận yêu cầu của người dùng sau đó thành lập các chuối truy vấn – query string để gửi cho server. Khi nhận được kết quả từ server, client sẽ tổ chức và trình diễn những kết quả đó. Nhiều mạng công ty bao gồm một máy khách cho mỗi nhân viên, mỗi mạng đều kết nối với máy chủ của công ty. Máy chủ cung cấp các tài nguyên như tệp, thông tin, truy cập Internet và mạng nội bộ cũng như sức mạnh xử lý bên ngoài. Trong trường hợp xử lý, bất kỳ công việc nào được thực hiện trên máy chủ được gọi là công việc “phía máy chủ”. Mọi công việc được thực hiện trên máy khách cục bộ tương tự được gọi là “phía máy khách”. Ví dụ sau so sánh tập lệnh phía máy khách và tập lệnh phía máy chủ, đồng thời giải thích cách máy tính khách tương tác với máy chủ Internet."
                + "<br></br>" + "Client – server là một loại mô hình mạng máy tính bao gồm 02 thành phần là máy chủ và máy khách. Client Server ra đời để chỉ những máy chủ lưu giữ thông tin dữ liệu và các thuật toán truyền tin trong hệ thống máy tính. Người dùng hệ thống sẽ chỉ cần điều khiển máy chủ server là có thể kiểm soát dữ liệu truyền đi, hoạt động và cả việc điều khiển tác vụ của các máy con nằm trong hệ thống. Server ra đời với mục đích lưu trữ tất cả các thông tin mà mạng máy tính sử dụng, giúp người dùng quản lý hệ thống dễ dàng hơn. Với sự phát triển của internet như hiện nay, server còn được phát triển thêm để phục vụ những tác vụ phức tạp hơn và từ đó chúng ta có thêm những khái niệm chuyên môn hơn như server side, …"
                + "<br></br>" + "Client Trong mô hình client/server, người ta còn định nghĩa cụ thể cho một máy client là một máy trạm mà chỉ được sử dụng bởi 1 người dùng với để muốn thể hiện tính độc lập cho nó. Máy client có thể sử dụng các hệ điều hành bình thường như Win9x, DOS, OS/2… Bản thân mỗi một client cũng đã được tích hợp nhiều chức năng trên hệ điều hành mà nó chạy, nhưng khi được nối vào một mạng LAN, WAN theo mô hình client/server thì nó còn có thể sử dụng thêm các chức năng do hệ điều hành mạng (NOS) cung cấp với nhiều dịch vụ khác nhau (cụ thể là các dịch vụ do các server trên mạng này cung cấp), ví dụ như nó có thể yêu cầu lấy dữ liệu từ một server hay gửi dữ liệu lên server đó.",
                Url = "https://wikimaytinh.com/may-client-la-gi-may-khach-la-gi.html",
                Video = "https://www.youtube.com/embed/SwLdKeC8scE"

            });
            arr.Add(new Danhsachmon() { 
                ID = 3, 
                Img = "Img/pic4.png", 
                Des = "Server ", 
                Type = "môn chính" 
            });
            arr.Add(new Danhsachmon() { 
                ID = 4, 
                Img = "Img/pic5.png", 
                Des = "Các kiến thức về thương mại điện tử", 
                Type = "môn chính" 
            });
            arr.Add(new Danhsachmon()
            {
                ID = 5,
                Img = "Img/pic7.png",
                Des = "Cơ sở dữ liệu",
                Type = "môn phụ"
            });
            arr.Add(new Danhsachmon()
            {
                ID = 6,
                Img = "Img/pic8.png",
                Des = "Hệ quản trị cơ sở dữ liệu",
                Type = "môn phụ"
            }); arr.Add(new Danhsachmon()
            {
                ID = 7,
                Img = "Img/pic9.png",
                Des = "Công nghệ truy cập cơ sở dữ liệu",
                Type = "môn phụ"
            }); arr.Add(new Danhsachmon()
            {
                ID = 8,
                Img = "Img/pic9.png",
                Des = "Công nghệ truy cập cơ sở dữ liệu",
                Type = "môn phụ"
            });

            Application["Khachtruycap"] = 0;
            

            Application["dsmon"] = arr;
        }
        protected void Session_Start(object sender, EventArgs e)
        {
            Session["login"] = false;
            Session["id"] = "";
            Session["email"] = "";
            Session["Name"] = "";
            Session["Pass"] = "";
            Session["Doituong"] = "";
            Session["Timkiem"] = new List<Danhsachmon>();
            if(Application["Khachtruycap"] != null)
            {
                Application.Lock();
                Application["Khachtruycap"] = Convert.ToInt32(Application["Khachtruycap"].ToString()) + 1;
                Application.UnLock();
            }
            
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {
            
                Application.Lock();
                Application["Khachtruycap"] = Convert.ToInt32(Application["Khachtruycap"].ToString()) - 1;
                Application.UnLock();
            
        }

        protected void Application_End(object sender, EventArgs e)
        {
           
        }
        
    }
}