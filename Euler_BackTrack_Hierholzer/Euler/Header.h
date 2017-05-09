#include <glut.h>
#include <gl/GL.h>
#include <gl/GLU.h>
#include <vector>
#include <iostream>
#include <Windows.h> //dùng hàm Sleep
#include <sstream> //khai báo để dùng std::to_string
#include <stack>
#include <math.h>
using namespace std;

/* màu sắc */
struct myRGB {
	float red, green, blue;
};

/* tọa độ */
struct myPOINT {
	int x, y; //tọa độ trong màn hình windows
};
struct Canh {
	int dinh1,dinh2; // Thứ tự 2 đỉnh của 1 cạnh trong danh sách đỉnh.
	bool duyet;
};

/* mỗi đỉnh của đồ thị */
struct myNODE {
	myPOINT Tam; //Tâm đỉnh (tâm đường tròn)
	vector<int> DS_DinhKe;
};
/*
- Các tham số trong chương trình được tổng hợp ở đây để dễ quản lý
- Để thay đổi giá trị, hãy vào hàm mySetting()
*/
int EulerFound; //-1: không tìm thấy đường đi Euler; 0, 1, 2...: thứ tự đường đi
int QuangDuong; //quãng đường vẽ của từng cạnh

bool veDinh;
bool veCanh;
bool Euler;
int SoCanhDaDuyet;
string title;
bool movingNode; //lưu trạng thái có đang thay đổi vị trí đỉnh hay không
int ViTriTrung; //lưu đỉnh đang được di chuyển
void motion(int x, int y);//hàm thực hiện khi di chuyển vị trí đỉnh
int Dinh_1, Dinh_2; //2 đỉnh khi tạo cạnh
int Dinh_1_Xoa, Dinh_2_Xoa; //2 đỉnh khi xóa cạnh
bool firstTime; //biến tạm
int sleeptime;

const char* WindowName;
int WindowWidth, WindowHeight; //kích thước window
int x_Pos, y_Pos; //vị trí xuất hiện của window
myRGB BackgroundColor; //màu nền window

int Title_x, Title_y; //tọa độ hiện tiêu đề trên window
string Title_content; //nội dung tiêu đề trên window
string Button_Tuy_Chon; //nội dung tren nut ve Dinh.
myRGB TitleColor; //màu của tiêu đề

float PointSize; //kích cỡ mỗi GL_POINTS
int Circle_R; //bán kính đỉnh của đồ thị
myRGB NodeColor; //màu đỉnh của đồ thị
myRGB CharacterColor; //màu sắc của tên đỉnh

vector<myNODE> NodeList; //danh sách đỉnh
vector<Canh> DSCanh; //danh sách cạnh của đồ thị.
vector<int> DuongDiEuler; // danh sách đỉnh trong đường đi Euler.

void Init(); //Hàm thực hiện các khởi tạo
void RenderScene(); //Hàm chịu trách nhiệm chính trong việc vẽ lên window
void ReShape(int width, int height); //Các thao tác cần làm khi window bị thay đổi kích thước
void mouseClick(int button, int buttonState, int x, int y); //Hàm thực hiện các thao tác chuột
void drawNode(); //Hàm vẽ đỉnh của đồ thị
void VeCanh(myNODE n, myNODE m); //Ve Canh tu 2 dinh, màu mặc định trong hàm
void VeCanh(myNODE n, myNODE m, myRGB color); //Vẽ cạnh từ 2 đỉnh, truyền màu vào tự do
void VeCanhDoThi(); // Ve canh cua do thi.
void VeChuyenDongEuler(); //Vẽ chuyển động cho đường đi Euler

void TuyChonVe(); // Ham cac lua chon ve.
int TimDinh(int x, int y); // Ham Tim dinh
bool KeNhau(int n, int m); // Kiem tra hai dinh n m trong danh sach dinh co ke nhau hay khong
int KiemTraDinhTrung(vector<myNODE> NodeList, myNODE n); // Kiểm tra xem đỉnh sắp vẽ có đè lên đỉnh nào đã tồn tại hay không
bool Backtrack(int DinhBatDau); //Thuật toán timd đường đi Euler.
bool Hierholzer(int DinhBatDau);
int DinhLeDauTien(); //Tim đình bậc lẻ đầu tiên của đồ thị.
int TimCanh(int dinh1, int dinh2);

void Mouse_Left_Button_Up(myNODE n);
void Mouse_Left_Button_Down(myNODE n);
void XoaCanh(myNODE n);
void Reset();

void mySetting(); //Hàm thực hiện các tùy chỉnh cá nhân
void SetNodeColor(float red, float green, float blue); //Hàm tùy chỉnh màu của đỉnh
void SetCharacterColor(float red, float green, float blue); //Hàm tùy chỉnh màu của tên đỉnh
void SetBackgroundColor(float red, float green, float blue); //Hàm tùy chỉnh màu nền window
void SetWindowSize(int width, int height); //Hàm tùy chỉnh kích thước window
void SetWindowPosition(int x, int y);
void SetTitle(int x, int y, string content, float red, float green, float blue); //Hàm tùy chỉnh tiêu đề trên window
int DemSoDinhLe(vector<myNODE> NodeList);
void printtext(int x, int y, string String); //Hàm in chuỗi ra màn hình

											 /*
											 OpenGL không có sẵn hàm vẽ đường tròn, nên mình phải tự vẽ :(
											 Các hàm bổ trợ việc vẽ đường tròn theo thuật toán MidPoint
											 Tham khảo tại: https://www.stdio.vn/articles/read/276/thuat-toan-midpoint-ve-duong-tron
											 Các hàm đã được chỉnh sửa để phù hợp với OpenGl và tiện lợi với project này
											 Thuật toán của các hàm này mình không tìm hiểu sâu nên sẽ không giải thích
											 */
void put8pixel(int xc, int yc, int x, int y);
void drawCircleMidpoint(int xc, int yc, int r, myRGB color);
//---------------------------------