// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;

// namespace LearnC
// {
//     class Program
//     {

//         // static void Main(string[] args)
//         // {
//         //     string[] stringArray = { "text1", "text2", "text3", "text4" };
//         //     string value = "text";
//         //     int pos = Array.IndexOf(stringArray, value);
//         //     Console.Write(pos);
//         // }


//         /// đề bài:
//         /// nhập số n phần tử từ bàn phím
//         /// hiển thị danh sách vừa nhập
//         /// liệt kê các phần tử lẻ trong mảng và tính tổng
//         /// nhập 1 số bất kỳ từ bàn phím. kiểm tra xem số đó,có ở trong mảng ko? hiển thị ra vị trí của phần tử đó
//         static void Main(string[] args)
//         {
//             Program p = new Program();
//             Console.WriteLine("Nhap vao so phan tu cua mang");
//             /// nhập từ bàn phím số lượng phần tử của mảng
//             int sizeEmelemtArray = int.Parse(Console.ReadLine());
//             if (sizeEmelemtArray > 0)
//             {
//                 /// khởi tạo 1 mảng có kiểu dữ liệu là "int" 
//                 int[] array = new int[sizeEmelemtArray];
//                 for (int i = 0; i < array.Length; i++)
//                 {
//                     Console.Write("array[" + i + "] = ");
//                     /// lấy giá trị từ bàn phím và chuyển đổi nó thành kiểu int rồi lưu vào mảng
//                     array[i] = int.Parse(Console.ReadLine());
//                 }
//                 Console.WriteLine("check array", array);

//                 /// hàm hiển thị số  phần tử của mảng
//                 p.displayArray(array);
//                 /// hàm tính chẵn lẻ
//                 p.handleParity(array);
//                 /// hàm kiểm tra xem phần tử có trong mảng ko
//                 p.isCheckArray(array);
//             }
//             else
//             {
//                 Console.Write("\nVui lonng nhap lai n > 1");
//             }

//             Console.ReadKey();
//         }

//         /// hàm ko trả về giá trị tại vì có từ "void" và nó nhận vào 1 tham số là 1 mảng
//         void displayArray(int[] param)
//         {
//             Console.WriteLine("mang vua nhap la: ");
//             for (int i = 0; i < param.Length; i++)
//             {
//                 /// vì index cua mảng bắt đầu là số 0
//                 Console.WriteLine("index: " + i + " " + "value: " + param[i] + " , ");
//             }
//         }

//         /// hàm ko trả về giá trị tại vì có từ "void" và nó nhận vào 1 tham số là 1 mảng
//         void handleParity(int[] param)
//         {
//             int tong = 0;
//             Console.Write("\nCac phan tu le trong mang la la: ");
//             for (int i = 0; i < param.Length; i++)
//             {
//                 if (param[i] % 2 != 0)
//                 {
//                     tong += param[i];
//                     Console.Write("index:" + i + " value:" + param[i] + " , ");
//                 }

//             }
//             Console.Write("\nTong cac phan tu le cua mang la: {0}", tong);
//         }
//         /// hàm ko trả về giá trị tại vì có từ "void" và nó nhận vào 1 tham số là 1 mảng
//         void isCheckArray(int[] param)
//         {
//             Console.WriteLine("\nNhap vao so can kiem tra: ");
//             /// lấy giá trị từ bàn phím và chuyển đổi nó thành kiểu int
//             int inputKeyboard = int.Parse(Console.ReadLine());
//             /// hàm Array.IndexOf => dùng để kiểm tra xem một phần tử có tồn tại trong mảng ko
//             /// nó nhận 2 tham số : 1 mảng muốn kiểm tra ,2 giá trị muốn kiểm tra
//             /// nó trả về -1 tức là mảng ko chứa phần tử mình muốn kiểm tra và khác trừ 1 chính là index của phần tử đó luôn
//             int index = Array.IndexOf(param, inputKeyboard);
//             if (index > -1)
//             {
//                 Console.WriteLine("So ban nhap nam trong mang index la:{0} ", index);

//             }
//             else
//             {
//                 Console.WriteLine("So ban nhap ko nam trong mang ");
//             }

//         }


//     }
// }



