#include "Header.h"

int main() {
	mySetting(); //thực hiện các tùy chỉnh cá nhân
	glutInitDisplayMode(GLUT_SINGLE | GLUT_RGB); //khởi tạo chế độ vẽ single buffer và hệ màu RGB
	glutInitWindowSize(WindowWidth, WindowHeight); //khởi tạo window
	glutInitWindowPosition(x_Pos, y_Pos); //khởi tạo window tại ví trí x_Pos, y_Pos trên screen
	glutCreateWindow(WindowName); //đặt tên cho window
								  /* thiết lập lại hiển thị tọa độ từ 3D sang 2D */
	glDisable(GL_DEPTH_TEST);
	glMatrixMode(GL_PROJECTION);
	glLoadIdentity();
	glOrtho(0, WindowWidth, WindowHeight, 0, 0, 1);
	glMatrixMode(GL_MODELVIEW);
	//-----------------------

	Init();
	glutReshapeFunc(ReShape); //đăng ký hàm ReShape cho sự kiện cửa sổ bị thay đổi kích thước
	glutDisplayFunc(RenderScene); //thiết lập hàm vẽ là hàm RenderScene

	glutIdleFunc(RenderScene); //gọi liên tục đến hàm RenderScene

	glutMouseFunc(mouseClick); // đăng ký hàm mouseClick cho sự kiện chuột
	glutMotionFunc(motion); //đăng ký hàm motion cho sự kiện con trỏ chuột di chuyển
	glutMainLoop(); //bắt đầu chu trình lặp thể hiện vẽ
	return 0;
}

/*
* Các thao tác cần làm khi window bị thay đổi kích thước
*/
void ReShape(int width, int height) {
	glutReshapeWindow(WindowWidth, WindowHeight); //Giữ nguyên kích thước ban đầu, không cho resize hihi ^.^
												  //nguồn tham khảo: http://stackoverflow.com/questions/10691603/is-it-possible-to-create-a-fixed-size-glut-window
}

/*
* Hàm thực hiện các khởi tạo
*/
void Init() {
	glClearColor(BackgroundColor.red, BackgroundColor.green, BackgroundColor.blue, 0.0); //chọn màu nền - (0.0, 0.0, 0.0, 0.0 là màu đen)
	glShadeModel(GL_FLAT); //GL_SMOOTH: chế độ hòa trộn màu; GL_FLAT: chế độ màu đơn
}


void mouseClick(int button, int buttonState, int x, int y) {
	//if (EulerFound != -1 && button != GLUT_MIDDLE_BUTTON)
	//	return; //khi xác định Euler xong phải Reset tất cả

	myNODE n;
	n.Tam.x = x;
	n.Tam.y = y;

	if (button == GLUT_LEFT_BUTTON && buttonState == GLUT_UP && EulerFound == -1) { //chuột trái
		Mouse_Left_Button_Up(n);
	}

	if (button == GLUT_LEFT_BUTTON && buttonState == GLUT_DOWN && veDinh == true && EulerFound == -1) {
		Mouse_Left_Button_Down(n);
	}

	if (button == GLUT_RIGHT_BUTTON && buttonState == GLUT_UP && veCanh == true && EulerFound == -1) { //xóa cạnh
		XoaCanh(n);
	}

	if (button == GLUT_RIGHT_BUTTON && buttonState == GLUT_UP && EulerFound != -1) {
		increaseEulerFound = true;
	}

	if (button == GLUT_MIDDLE_BUTTON && buttonState == GLUT_UP) {
		Reset();
	}

	glutPostRedisplay(); //hàm yêu cầu vẽ lại
}
bool KeNhau(int n, int m)
{
	int z = NodeList[n].DS_DinhKe.size();
	for (int i = 0; i < z; i++)
	{
		if (NodeList[n].DS_DinhKe[i] == m)
		{
			return true;
		}
	}
	return false;
}

int KiemTraDinhTrung(vector<myNODE> NodeList, myNODE n) {
	int x = n.Tam.x;
	int y = n.Tam.y;
	int size = NodeList.size();
	for (int i = 0; i < size; i++)
	{
		int x_left = NodeList[i].Tam.x - 2 * Circle_R;
		int x_right = NodeList[i].Tam.x + 2 * Circle_R;
		int y_top = NodeList[i].Tam.y - 2 * Circle_R;
		int y_bottom = NodeList[i].Tam.y + 2 * Circle_R;
		if (x_left <= x && x <= x_right && y_top <= y && y <= y_bottom)
			return i; //bị trùng => không cho vẽ, return vị trí của đỉnh trùng
	}
	return -1;
}

int TimDinh(int x, int y) // Ham tim dinh khi ng dung chan chuot vao man hinh.
{
	int n = NodeList.size();
	for (int i = 0; i < n; i++)
	{
		if (NodeList[i].Tam.x - Circle_R < x && x < NodeList[i].Tam.x + Circle_R) // vi ban kinh cua hinh tron la 15 nen coi nhu la hinh vuong co do dai canh la 30.
		{
			if (NodeList[i].Tam.y - Circle_R < y && y < NodeList[i].Tam.y + Circle_R)
			{
				return i;
			}
		}
	}
	return -1;
}

void drawNode() {
	int n = NodeList.size();
	for (int i = 0; i < n; i++) {
		glBegin(GL_POLYGON);
		drawCircleMidpoint(NodeList[i].Tam.x, NodeList[i].Tam.y, Circle_R, NodeColor);
		glEnd();

		/* in chữ vào khoảng giữa tâm đỉnh */
		string s = std::to_string(i);
		glColor3f(CharacterColor.red, CharacterColor.green, CharacterColor.blue);
		if (i <= 9)
		{
			printtext(NodeList[i].Tam.x - 5, NodeList[i].Tam.y + 5, s); //chữ xê dịch so với tâm đỉnh 1 chút cho đẹp
		}
		if (i > 9)
		{
			printtext(NodeList[i].Tam.x - 9, NodeList[i].Tam.y + 4, s); //chữ xê dịch so với tâm đỉnh 1 chút cho đẹp
		}
	}
}
void VeCanhDoThi()
{
	int n = NodeList.size();
	for (int i = 0; i < n; i++) 
	{
		for (int j = 0; j < NodeList[i].DS_DinhKe.size(); j++)
		{
			int k = NodeList[i].DS_DinhKe[j];
			VeCanh(NodeList[i], NodeList[k]);
		}
	}
}

void VeCanh(myNODE n, myNODE m)
{
	glLineWidth(3.0);
	glColor3f(0, 0, 1);
	glBegin(GL_LINES);
	glVertex3f(n.Tam.x, n.Tam.y, 0);
	glVertex3f(m.Tam.x, m.Tam.y, 0);
	glEnd();
}

void VeCanh(myNODE n, myNODE m, myRGB color)
{
	glLineWidth(6.0);
	glColor3f(color.red, color.green, color.blue);
	glBegin(GL_LINES);
	glVertex3f(n.Tam.x, n.Tam.y, 0);
	glVertex3f(m.Tam.x, m.Tam.y, 0);
	glEnd();
}

void VeChuyenDongEuler() {
	myRGB color = { 1.0, 0.0, 0.0 };
	int soCanh = DuongDiEuler.size() - 1;

	if (increaseEulerFound && EulerFound == soCanh)
		Reset();

	for (int i = 0; i < EulerFound; i++) {
		VeCanh(NodeList[DuongDiEuler[i]], NodeList[DuongDiEuler[i + 1]], color);
	}
	
	if (EulerFound < soCanh && increaseEulerFound) {
		EulerFound++;
		increaseEulerFound = false;
	}
	
}

void RenderScene() {
	glClear(GL_COLOR_BUFFER_BIT); //xóa mọi pixel
	glPointSize(PointSize);

	glColor3f(TitleColor.red, TitleColor.green, TitleColor.blue);
	printtext(Title_x, Title_y, Title_content);

	
	VeCanhDoThi();
	if (EulerFound != -1)
		VeChuyenDongEuler();
	drawNode();
	TuyChonVe();
	glutSwapBuffers(); //thực hiện việc hoán đổi 2 buffer
	glFlush(); //thực hiện quá trình đẩy ra buffer
	Sleep(20); //cho nó nghỉ chút đỡ giật máy :(
}

void printtext(int x, int y, string String) {
	glMatrixMode(GL_PROJECTION);
	glPushMatrix();
	glLoadIdentity();
	glOrtho(0, WindowWidth, WindowHeight, 0, 0, 1);
	glMatrixMode(GL_MODELVIEW);
	glPushMatrix();
	glLoadIdentity();
	glPushAttrib(GL_DEPTH_TEST);
	glDisable(GL_DEPTH_TEST);
	glRasterPos2i(x, y);
	for (int i = 0; i < String.size(); i++) {
		glutBitmapCharacter(GLUT_BITMAP_9_BY_15, String[i]);
	}
	glPopAttrib();
	glMatrixMode(GL_PROJECTION);
	glPopMatrix();
	glMatrixMode(GL_MODELVIEW);
	glPopMatrix();
} //nguồn tham khảo: http://cnttdhsupham.forumotion.com/t2162-topic

void put8pixel(int xc, int yc, int x, int y)
{
	glVertex2i(x + xc, y + yc);
	glVertex2i(-x + xc, y + yc);
	glVertex2i(x + xc, -y + yc);
	glVertex2i(-x + xc, -y + yc);
	glVertex2i(y + xc, x + yc);
	glVertex2i(-y + xc, x + yc);
	glVertex2i(y + xc, -x + yc);
	glVertex2i(-y + xc, -x + yc);
}

void drawCircleMidpoint(int xc, int yc, int r, myRGB color) {
	glColor3f(color.red, color.green, color.blue);
	int x = 0; int y = r;
	int f = 1 - r;
	put8pixel(xc, yc, x, y);
	while (x < y)
	{
		if (f < 0) f += (x << 1) + 3;
		else
		{
			y--;
			f += ((x - y) << 1) + 5;
		}
		x++;
		put8pixel(xc, yc, x, y);
	}
}
void TuyChonVe()
{
	glColor3f(1, 0.5, 0);
	glBegin(GL_LINES);
	glVertex3f(0, 60, 0);
	glVertex3f(WindowWidth, 60, 0);
	glEnd();
	if (veDinh == true)
	{
		glColor3f(0.2, 0.7, 0);
	}
	else
	{
		glColor3f(1, 0, 0);
	}
	glBegin(GL_QUADS); // Khung chon ve dinh;
	glVertex3f((WindowWidth / 6) * 2 - 30, 30, 0);
	glVertex3f((WindowWidth / 6) * 2 + 50, 30, 0);
	glVertex3f((WindowWidth / 6) * 2 + 50, 60, 0);
	glVertex3f((WindowWidth / 6) * 2 - 30, 60, 0);
	glEnd();
	Button_Tuy_Chon = "Ve Dinh";
	glColor3f(1, 1, 0);
	printtext((WindowWidth / 6) * 2 - 20, 50, Button_Tuy_Chon);


	if (veCanh == true)
	{
		glColor3f(0.2, 0.7, 0);
	}
	else
	{
		glColor3f(1, 0, 0);
	}
	glBegin(GL_QUADS); // Khung chon noi canh;
	glVertex3f((WindowWidth / 6) * 3 - 30, 30, 0);
	glVertex3f((WindowWidth / 6) * 3 + 50, 30, 0);
	glVertex3f((WindowWidth / 6) * 3 + 50, 60, 0);
	glVertex3f((WindowWidth / 6) * 3 - 30, 60, 0);
	glEnd();
	Button_Tuy_Chon = "Noi Canh";
	glColor3f(1, 1, 0);
	printtext((WindowWidth / 6) * 3 - 25, 50, Button_Tuy_Chon);


	if (Euler == true)
	{
		glColor3f(0.2, 0.7, 0);
	}
	else
	{
		glColor3f(1, 0, 0);
	}
	glBegin(GL_QUADS); // Khung chon tim duong euler;
	glVertex3f((WindowWidth / 6) * 4 - 30, 30, 0);
	glVertex3f((WindowWidth / 6) * 4 + 50, 30, 0);
	glVertex3f((WindowWidth / 6) * 4 + 50, 60, 0);
	glVertex3f((WindowWidth / 6) * 4 - 30, 60, 0);
	glEnd();
	Button_Tuy_Chon = "Euler";

	glColor3f(1, 1, 0);
	printtext((WindowWidth / 6) * 4 - 25, 50, Button_Tuy_Chon);

	//
	if (veDinh == false && veCanh == false && Euler == false)
	{
		title = "Hay chon hinh thuc ve";
		SetTitle(10, 20, title, 1.0, 0.0, 0.0);
	}
	if (veDinh == true)
	{
		title = "Nhap chuot trai de ve dinh";
		SetTitle(10, 20, title, 1.0, 0.0, 0.0);
	}
	if (veCanh == true)
	{
		title = "Chon hai dinh de noi canh";
		SetTitle(10, 20, title, 1.0, 0.0, 0.0);
	}
	if (Euler == true)
	{
		if (DemSoDinhLe(NodeList) == 0 || DemSoDinhLe(NodeList) == 2)
		{
		}
		else
		{
			title = "Khong ton tai duong di Euler cho do thi nay :";
			SetTitle(10, 20, title, 1.0, 0.0, 0.0);
		}
			
	}
}

void motion(int x, int y) {
	if (movingNode) {
		NodeList[ViTriTrung].Tam.x = x;
		NodeList[ViTriTrung].Tam.y = y;
		glutPostRedisplay();
	}
}
int DemSoDinhLe(vector<myNODE> NodeList)
{
	int demDinhLe = 0;
	int size = NodeList.size();
	for (int i = 0; i < size; i++)
	{
		if (NodeList[i].DS_DinhKe.size() % 2 != 0)
		{
			demDinhLe++;
		}
	}
	return demDinhLe;
}
/* -------------------------------------------------------------------
- Các hàm tùy chỉnh cá nhân, được tạo ra để dễ quản lý, thay đổi các thông số của đối tượng
*/
void mySetting() {
	WindowName = "OpenGL demo";
	PointSize = 1.0f;
	Circle_R = 15;
	SetWindowSize(1000, 500);
	SetWindowPosition(100, 100);
	SetNodeColor(0.0, 0.0, 1.0);
	SetCharacterColor(1.0, 1.0, 0.0);
	SetBackgroundColor(0.75, 0.75, 0.75);
	veDinh = false;
	veCanh = false;
	Euler = false;
	movingNode = false;
	firstTime = true;
	increaseEulerFound = false;
	ViTriTrung = -1;
	Dinh_1 = NULL;
	Dinh_2 = NULL;
	Dinh_1_Xoa = NULL;
	Dinh_2_Xoa = NULL;
	SoCanhDaDuyet = 0;
	EulerFound = -1;
}

void SetWindowSize(int width, int height) {
	WindowWidth = width;
	WindowHeight = height;
}

void SetNodeColor(float red, float green, float blue) {
	NodeColor.red = red;
	NodeColor.green = green;
	NodeColor.blue = blue;
}

void SetCharacterColor(float red, float green, float blue) {
	CharacterColor.red = red;
	CharacterColor.green = green;
	CharacterColor.blue = blue;
}

void SetBackgroundColor(float red, float green, float blue) {
	BackgroundColor.red = red;
	BackgroundColor.green = green;
	BackgroundColor.blue = blue;
}

void SetTitle(int x, int y, string content, float red, float green, float blue) {
	Title_x = x;
	Title_y = y;
	Title_content = content;
	TitleColor.red = red;
	TitleColor.green = green;
	TitleColor.blue = blue;
}

void SetWindowPosition(int x, int y) {
	x_Pos = x;
	y_Pos = y;
}

/* ----- Các hàm xử lý chuột -----*/

void Mouse_Left_Button_Up(myNODE n) {
	movingNode = false;

	// Neu nhan chuot vao vung ve dinh.
	if (n.Tam.x > ((WindowWidth / 6) * 2 - 30) && n.Tam.x < ((WindowWidth / 6) * 2 + 50) && n.Tam.y > 30 && n.Tam.y < 60) // Nhan chuot vao vung ve dinh
	{
		veDinh = true;
		veCanh = false;
		Euler = false;
	}

	// Neu nhan chuot vao vung noi canh.
	if (n.Tam.x >((WindowWidth / 6) * 3 - 30) && n.Tam.x < ((WindowWidth / 6) * 3 + 50) && n.Tam.y > 30 && n.Tam.y < 60) // nhan chuot vao vung chon noi canh
	{
		veDinh = false;
		veCanh = true;
		Euler = false;
		Dinh_1 = -1;
		Dinh_2 = -1;
		Dinh_1_Xoa = -1;
		Dinh_2_Xoa = -1;
	}
	if (veCanh == true) // Neu lua chon dang la noi canh
	{
		if (TimDinh(n.Tam.x, n.Tam.y) != -1)
		{
			if (Dinh_2 == -1 && Dinh_1 != -1 && TimDinh(n.Tam.x, n.Tam.y) != Dinh_1)
			{
				Dinh_2 = TimDinh(n.Tam.x, n.Tam.y);
				// Neu 2 dinh da ke nhau thi khong them vao ds_ke nua.
				if (KeNhau(Dinh_1, Dinh_2) == false)
				{
					NodeList[Dinh_1].DS_DinhKe.push_back(Dinh_2);
					NodeList[Dinh_2].DS_DinhKe.push_back(Dinh_1);
					Canh canhMoi;
					canhMoi.dinh1 = Dinh_1;
					canhMoi.dinh2 = Dinh_2;
					canhMoi.duyet = false;
					DSCanh.push_back(canhMoi);
				}
				//printf("\n Toa do dinh 2 la: (%d, %d)", NodeList[Dinh_2].Tam.x, NodeList[Dinh_2].Tam.y);

			}
			if (Dinh_1 == -1)
			{
				Dinh_1 = TimDinh(n.Tam.x, n.Tam.y);
				//printf("\n Toa do dinh 1 la: (%d, %d)", NodeList[Dinh_1].Tam.x, NodeList[Dinh_1].Tam.y);
			}
			if (Dinh_2 != -1 && Dinh_1 != -1)
			{
				Dinh_1 = -1;
				Dinh_2 = -1;
			}
		}
	}
	
	if (n.Tam.y > (60 + Circle_R) && n.Tam.y < (WindowHeight - Circle_R) && n.Tam.x > Circle_R && n.Tam.x < (WindowWidth - Circle_R) && veDinh == true) // Chi duoc ve trong vung co y > 60
	{
		if (KiemTraDinhTrung(NodeList, n) == -1) //không có đỉnh nào bị đè lên mới được vẽ
			NodeList.push_back(n); // Day dinh n vao trong danh sach dinh.
	}
	// Neu nhan chuot Euler
	if (n.Tam.x > ((WindowWidth / 6) * 4 - 30) && n.Tam.x < ((WindowWidth / 6) * 4 + 50) && n.Tam.y > 30 && n.Tam.y < 60) // nhan chuot vao vung Euler
	{
		SoCanhDaDuyet = 0;
		for (int i = 0; i < DSCanh.size(); i++)
		{
			DSCanh[i].duyet = false; // Gan tat ca cac canh la chua dc duyet.
		}
		DuongDiEuler.clear();// Xoa tat ca dinh trong vector chua cac dinh trong duong di.
		veDinh = false;
		veCanh = false;
		Euler = true;

		// Tim duong khi nhan vao Khung Euler xuat ra thu tu cac dinh trong duong di vao title tren cung cua cua so
		string strduongdi ;
		
		int sodinhle = DemSoDinhLe(NodeList);
		if ((sodinhle == 0 || sodinhle == 2) && laDoThiLienThong())
		{
			printf("\n Do thi co the co duong di euler");
			printf("\n so canh cua do thi la: %d \n",DSCanh.size());
			printf("\n so dinh le cua do thi la: %d \n", sodinhle);
			if (sodinhle == 0)
			{
				//---------- backtracking ----------
				//DuongDiEuler.push_back(0);
				//if (TimDuongEuler(0))
				//{
				//	for (int i = 0; i < DuongDiEuler.size(); i++)
				//	{
				//		printf("%d ", DuongDiEuler[i]);
				//		stringstream ss;
				//		ss << DuongDiEuler[i];
				//		if (i == DuongDiEuler.size() - 1)
				//		{
				//			strduongdi = strduongdi + ss.str();
				//		}
				//		else
				//		{
				//			strduongdi = strduongdi + ss.str() + " -> ";
				//		}
				//		
				//	}
				//	title = "duong di Euler la: " + strduongdi;
				//}
				//else
				//{
				//	title = "Khong ton tai duong di Euler: " + strduongdi;
				//	printf("khong ton tai duong di euler");
				//}

				//---------- Fleury ----------
				Fleury(0);
			}
			else
			{
				//---------- backtracking ----------
				//DuongDiEuler.push_back(DinhLeDauTien());
				//if (TimDuongEuler(DinhLeDauTien()))
				//{
				//	for (int i = 0; i < DuongDiEuler.size(); i++)
				//	{
				//		printf("%d ", DuongDiEuler[i]);
				//		stringstream ss;
				//		ss << DuongDiEuler[i];
				//		if (i == DuongDiEuler.size() - 1)
				//		{
				//			strduongdi = strduongdi + ss.str();
				//		}
				//		else
				//		{
				//			strduongdi = strduongdi + ss.str() + " -> ";
				//		}
				//	}
				//	title = "duong di Euler la: " + strduongdi;
				//}
				//else
				//{
				//	title = "Khong ton tai duong di Euler: " + strduongdi;
				//	printf("khong ton tai duong di euler");
				//}

				//---------- Fleury ----------
				Fleury(DinhLeDauTien());

			}
			for (int i = 0; i < DuongDiEuler.size(); i++)
			{
				printf("%d ", DuongDiEuler[i]);
				stringstream ss;
				ss << DuongDiEuler[i];
				if (i == DuongDiEuler.size() - 1)
				{
					strduongdi = strduongdi + ss.str();
				}
				else
				{
					strduongdi = strduongdi + ss.str() + " -> ";
				}	
			}
			title = "duong di Euler la: " + strduongdi;

			SetTitle(10, 20, title, 1.0, 0.0, 0.0);
			EulerFound = 0;
			PrintInfo();
		}
		else {
			SetTitle(10, 20, "Do thi khong phai Euler hoac nua Euler nen khong ton tai duong di Euler", 1.0, 0.0, 0.0);
			printf("Do thi khong phai Euler hoac nua Euler nen khong ton tai duong di Euler");
		}
			
	}
}
int DinhLeDauTien()
{
	int size = NodeList.size();
	for (int i = 0; i < size; i++)
	{
		if (NodeList[i].DS_DinhKe.size() % 2 != 0)
		{
			return i;
		}
	}
}
int TimCanh(int dinh1, int dinh2)
{
	for (int i = 0; i < DSCanh.size(); i++)
	{
		if ((DSCanh[i].dinh1 == dinh1 && DSCanh[i].dinh2 == dinh2) || (DSCanh[i].dinh2 == dinh1 && DSCanh[i].dinh1 == dinh2))
			return i;
	}
	return -1;
}

// Hàm tìm đường đi Euler.
bool TimDuongEuler(int DinhBatDau)
{
	// Nếu như số cạnh đã duyệt qua bằng với số cạnh của đồ thị thì kết thúc
	if (SoCanhDaDuyet == DSCanh.size())
	{
		return true;
	}
	int sizeDinhKe = NodeList[DinhBatDau].DS_DinhKe.size();
	// Nếu như đỉnh này có đỉnh kề với nó thì
	if (sizeDinhKe != 0)
	{
		// Với từng đỉnh kề ta làm.
		for (int i = 0; i < sizeDinhKe; i++)
		{
			//Tìm cạnh nối giữa đỉnh đó và đỉnh kề đang xét.
			int canhdangxet = TimCanh(DinhBatDau, NodeList[DinhBatDau].DS_DinhKe[i]);
			// nếu như cạnh trên chưa được duyệt
			if (canhdangxet != -1)
			{
				if (DSCanh[canhdangxet].duyet == false)
				{
					// Duyệt cạnh đó
					DSCanh[canhdangxet].duyet = true;
					// Tăng số cạnh đã duyệt lên 1.
					SoCanhDaDuyet++;
					// đưa đỉnh kề đang xet vào trong đường đi
					DuongDiEuler.push_back(NodeList[DinhBatDau].DS_DinhKe[i]);
					// Đệ quy tìm đến đỉnh cuối cùng của nhánh cây đường đi từ đỉnh DinhBatDau
					// Nếu như đỉnh cuối cùng của nhánh cây đường chính là đỉnh kết thúc của đường đi Euler thì kết thúc hàm.
					if (TimDuongEuler(NodeList[DinhBatDau].DS_DinhKe[i]))
						// Khi hàm kết thúc thì Danh sách đỉnh trong đường đi Euler sẽ nằm trong vector DuongDiEuler.
						return true;
					else
					{
						DSCanh[canhdangxet].duyet = false;
						SoCanhDaDuyet--;
						DuongDiEuler.pop_back();
					}
				}
			}
		}
	}
	// Nếu như đỉnh này ko có bất cứ đỉnh nào kề với nó và số cạnh đã duyệt chưa đủ thì
	else
	{
		// Giảm số cạnh đã duyệt đi 1.
		SoCanhDaDuyet--;
		// Tìm cạnh giữa đỉnh này và đỉnh cha của của nó gán lại là chưa xét.
		int canhdangxet = TimCanh(DinhBatDau, DuongDiEuler[DuongDiEuler.size() - 1]);
		DSCanh[canhdangxet].duyet = false;
		// Xóa đỉnh cha của nó ra khỏi đường đi.
		DuongDiEuler.pop_back();
		if (DuongDiEuler.size() == 0)
			return false;
	}
	return false;
}
void Mouse_Left_Button_Down(myNODE n) {
	ViTriTrung = KiemTraDinhTrung(NodeList, n);
	if (ViTriTrung != -1)
	{
		movingNode = true;
	}
}

void XoaCanh(myNODE n) {
	if (TimDinh(n.Tam.x, n.Tam.y) != -1)
	{
		if (Dinh_2_Xoa == -1 && Dinh_1_Xoa != -1 && TimDinh(n.Tam.x, n.Tam.y) != Dinh_1_Xoa)
		{
			Dinh_2_Xoa = TimDinh(n.Tam.x, n.Tam.y);
			// Neu 2 dinh da ke nhau thi khong them vao ds_ke nua.
			if (KeNhau(Dinh_1_Xoa, Dinh_2_Xoa) == true)
			{
				int size_1 = NodeList[Dinh_1_Xoa].DS_DinhKe.size();
				for (int i = 0; i < size_1; i++)
					if (NodeList[Dinh_1_Xoa].DS_DinhKe[i] == Dinh_2_Xoa) {
						NodeList[Dinh_1_Xoa].DS_DinhKe.erase(NodeList[Dinh_1_Xoa].DS_DinhKe.begin() + i);
						break;
					}

				int size_2 = NodeList[Dinh_2_Xoa].DS_DinhKe.size();
				for (int i = 0; i < size_2; i++)
					if (NodeList[Dinh_2_Xoa].DS_DinhKe[i] == Dinh_1_Xoa) {
						NodeList[Dinh_2_Xoa].DS_DinhKe.erase(NodeList[Dinh_2_Xoa].DS_DinhKe.begin() + i);
						break;
					}
				DSCanh.erase(DSCanh.begin() + TimCanh(Dinh_1_Xoa, Dinh_2_Xoa));
			}
		}

		if (Dinh_1_Xoa == -1)
			Dinh_1_Xoa = TimDinh(n.Tam.x, n.Tam.y);

		if (Dinh_2_Xoa != -1 && Dinh_1_Xoa != -1)
		{
			Dinh_1_Xoa = -1;
			Dinh_2_Xoa = -1;
		}
	}
}

void Reset() {
	NodeList.clear();
	DSCanh.clear();
	DuongDiEuler.clear();

	veDinh = false;
	veCanh = false;
	Euler = false;
	movingNode = false;
	firstTime = true;
	increaseEulerFound = false;
	ViTriTrung = -1;
	Dinh_1 = NULL;
	Dinh_2 = NULL;
	Dinh_1_Xoa = NULL;
	Dinh_2_Xoa = NULL;
	SoCanhDaDuyet = 0;
	EulerFound = -1;
	glutPostRedisplay();
}


void Fleury(int startNode) {
	DuongDiEuler.push_back(startNode);
	int currentNode = startNode;
	while(true){
		if (TinhSoCanhDaDuyet() == DSCanh.size())
			return;

		int SizeDinhKe = NodeList[currentNode].DS_DinhKe.size();
		bool TimDuocDinh = false;
		int DinhBenKiaCau;

		for (int i = 0; i < SizeDinhKe; i++) {
			int canh = TimCanh(currentNode, NodeList[currentNode].DS_DinhKe[i]);
			if (DSCanh[canh].duyet == false && TaoThemTPLT(canh) == false) {
				DSCanh[canh].duyet = true;
				DuongDiEuler.push_back(NodeList[currentNode].DS_DinhKe[i]);
				currentNode = NodeList[currentNode].DS_DinhKe[i];
				TimDuocDinh = true;
				break;
			}
		}
		
		if (TimDuocDinh == false) { //đành phải đi qua cầu
			for (int i = 0; i < SizeDinhKe; i++) {
				int canh = TimCanh(currentNode, NodeList[currentNode].DS_DinhKe[i]);
				if (DSCanh[canh].duyet == false && TaoThemTPLT(canh) == true) {
					DSCanh[canh].duyet = true;
					DuongDiEuler.push_back(NodeList[currentNode].DS_DinhKe[i]);
					currentNode = NodeList[currentNode].DS_DinhKe[i];
					break;
				}
			}
			
		}
	}
}

//---các hàm giúp xác định số lượng thành phần liên thông
bool TaoThemTPLT(int canh) {
	vector<string> input_1, input_2;
	int SoDinh = NodeList.size();
	input_1.push_back(toString(SoDinh));
	input_2.push_back(toString(SoDinh));
	for (int i = 0; i < SoDinh; i++) {
		string line_1 = "";
		string line_2 = "";
		for (int j = 0; j < SoDinh; j++) {
			string CoCanh = "";
			int CanhTimDuoc = TimCanh(i, j);
			if (i == j || CanhTimDuoc == -1 || (CanhTimDuoc != -1 && DSCanh[CanhTimDuoc].duyet))
				CoCanh = "0";
			else
				CoCanh = "1";

			if (CanhTimDuoc == canh) {
				if (j != SoDinh - 1) {
					line_1 += CoCanh + " ";
					line_2 += "0 ";
				}
				else {
					line_1 += CoCanh;
					line_2 += CoCanh;
				}
			}
			else {
				if (j != SoDinh - 1) {
					line_1 += CoCanh + " ";
					line_2 += CoCanh + " ";
				}
				else {
					line_1 += CoCanh;
					line_2 += CoCanh;
				}
			}
		}
		input_1.push_back(line_1);
		input_2.push_back(line_2);
	}
	DoThi DT_1, DT_2;
	int SoLuongTPLT_1 = xacDinhThanhPhanLT(input_1, input_1.size(), DT_1);
	int SoLuongTPLT_2 = xacDinhThanhPhanLT(input_2, input_2.size(), DT_2);
	delete[] DT_1.a;
	delete[] DT_2.a;
	if (SoLuongTPLT_2 > SoLuongTPLT_1)
		return true;
	return false;
}

bool laDoThiLienThong() {
	vector<string> input;
	int SoDinh = NodeList.size();
	input.push_back(toString(SoDinh));
	for (int i = 0; i < SoDinh; i++) {
		string line = "";
		for (int j = 0; j < SoDinh; j++) {
			string CoCanh = "";
			int CanhTimDuoc = TimCanh(i, j);
			if (i == j || CanhTimDuoc == -1)
				CoCanh = "0";
			else
				CoCanh = "1";

			if (j != SoDinh - 1)
				line += CoCanh + " ";
			else
				line += CoCanh;
		}
		input.push_back(line);
	}
	DoThi DT;
	int SoLuongTPLT = xacDinhThanhPhanLT(input, input.size(), DT);
	delete[] DT.a;
	if(SoLuongTPLT == 1)
		return true;
	return false;
}

int xacDinhThanhPhanLT(vector<string> lines, int size, DoThi &DT) {
	vector<string> rs;
	DT.soDinh = std::stoi(lines[0]);

	if (size == 1) {//không có cạnh
		return DT.soDinh;
	}

	DT.a = new int*[DT.soDinh];
	for (int i = 0; i < DT.soDinh; i++) {
		DT.a[i] = new int[2];
		DT.a[i][0] = i;//số thứ tự đỉnh
		DT.a[i][1] = 0;//thành phần liên thông mà đỉnh thuộc về - khởi tạo = 0 (chưa thuộc về TPLT nào)
	}

	//chuyển các dòng về ma trận cho dễ tính toán
	bool** matran = new bool*[DT.soDinh];
	for (int i = 0; i < DT.soDinh; i++)
		matran[i] = new bool[DT.soDinh];
	for (int i = 0; i < DT.soDinh; i++) {
		vector<int> trangThai = tachSo(lines[i + 1]);//0 hoặc 1
		for (int j = 0; j < DT.soDinh; j++)
			matran[i][j] = (bool)trangThai[j];
	}
	int tplt = 1;
	int dinhXet = 0;
	for (; tplt <= DT.soDinh; tplt++) {
		DFS(matran, dinhXet, tplt, DT);
		int dinhTiepTheo = dinhChuaXet(DT);
		if (dinhTiepTheo == -1)
			break;
		dinhXet = dinhTiepTheo;
	}
	delete[] matran;
	return tplt;
}

int dinhChuaXet(DoThi &DT) {
	for (int i = 0; i < DT.soDinh; i++)
		if (DT.a[i][1] == 0)
			return i;
	return -1;
}

void DFS(bool** matran, int d, int tplt, DoThi &DT) {
	DT.a[d][1] = tplt;
	for (int i = 0; i < DT.soDinh; i++) {
		if (matran[d][i] && DT.a[i][1] == 0) {
			DFS(matran, i, tplt, DT);
		}
	}
}

vector<int> tachSo(string line) {
	istringstream iss(line);
	vector<int> rs;
	do
	{
		string sub;
		iss >> sub;
		if (sub != "")
			rs.push_back(std::stoi(sub));
	} while (iss); //nguồn tham khảo: http://stackoverflow.com/questions/236129/split-a-string-in-c
	return rs;
}

string toString(int i) {
	long long k = i;
	return std::to_string(k);
}

int TinhSoCanhDaDuyet() {
	int n = DSCanh.size();
	int s = 0;
	for (int i = 0; i < n; i++)
		if (DSCanh[i].duyet)
			s++;
	return s;
}

void PrintInfo() {
	int n = NodeList.size();
	cout << "\n--- Danh sach dinh va cac dinh ke ---\n";
	for (int i = 0; i < n; i++) {
		cout << "[" << i << "]: ";
		int nn = NodeList[i].DS_DinhKe.size();
		for (int j = 0; j < nn; j++) {
			cout << NodeList[i].DS_DinhKe[j] << ", ";
		}
		cout << endl;
	}
	cout << "-------------------------------------\n";
}