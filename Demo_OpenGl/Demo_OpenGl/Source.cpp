#include "Header.h"

int main() {
	glutInitDisplayMode(GLUT_SINGLE | GLUT_RGB); //khởi tạo chế độ vẽ single buffer và hệ màu RGB
	glutInitWindowSize(500, 500); //khởi tạo window kích thước 500 x 500
	glutInitWindowPosition(100, 100); //khởi tạo window tại ví trí (100, 100) trên screen
	glutCreateWindow("Opengl demo"); //đặt tên cho window

	Init();
	glutReshapeFunc(ReShape); //đăng ký hàm ReShape cho sự kiện cửa sổ bị thay đổi kích thước
	glutDisplayFunc(RenderScene_1); //thiết lập hàm vẽ là hàm RenderScene

	glutIdleFunc(RenderScene_1); //gọi liên tục đến hàm RenderScene

	glutKeyboardFunc(OnKeyDown); //đăng ký hàm OnKeyDown cho sự kiện bàn phím

	glutMouseFunc(OnClick); // đăng ký hàm OnClick cho sự kiện chuột

	glutMainLoop(); //bắt đầu chu trình lặp thể hiện vẽ
	return 0;
}

/* demo vẽ các hình học cơ bản, phép quay và phép dịch */
void RenderScene_1() {
	glClear(GL_COLOR_BUFFER_BIT); //xóa mọi pixel
	glPointSize(10.0); //thiết lập size của point
	glLineWidth(5.0); //thiết lập width của line

	//glPushMatrix(); //lưu gốc tọa độ hiện tại vào stack trước khi dịch hoặc xoay

	//glRotatef(180, 0.0, 0.0, 1.0); //quay 90 độ theo trục z theo chiều phải -> trái
	//do ta chỉ vẽ ảnh 2D nên chỉ có thể xoay theo trục z
	//trục z là trục từ gốc tọa độ window đi ra mắt ta
		
	//glTranslatef(2.0, 1.0, 0.0); //dịch theo trục x thêm 2.0, trục y thêm 1.0
	
	//drawPoints();
	//drawLines();
	//drawLineStrip();
	//drawLineLoop();
	//drawTriangles();
	//drawTriangleStrip();
	//drawTriangleFan();
	//drawQuads();
	//drawQuadStrip();
	//drawPolygon();

	//glPopMatrix(); //lấy lại gốc tọa độ trong stack sau khi dịch hoặc xoay

	glutSwapBuffers(); //thực hiện việc hoán đổi 2 buffer
	glFlush(); //thực hiện quá trình đẩy ra buffer
}

/* demo xử lý chuột và bàn phím */
bool toRight = true;
float spin = 0.0f;
float tr = 0.0f;

bool isRotate = false; // biến trạng thái quay, ban đầu không quay
bool isTranslate = false; //biến trạng thái dịch, ban đầu không dịch

void RenderScene_2() {
	glClear(GL_COLOR_BUFFER_BIT); //xóa mọi pixel
	glPointSize(10.0); //thiết lập size của point
	glLineWidth(5.0); //thiết lập width của line

	glPushMatrix(); //lưu gốc tọa độ hiện tại vào stack

	glTranslatef(tr, tr, 0.0); //dịch theo trục x thêm 2.0

	glRotatef(spin, 0.0, 0.0, 1.0); //quay theo trục z một góc spin

	drawQuads();

	glPopMatrix(); //lấy lại gốc tọa độ trong stack

	glutSwapBuffers(); //thực hiện việc hoán đổi 2 buffer
	glFlush(); //thực hiện quá trình đẩy ra buffer
	
	//tính toán lại góc quay và độ dịch
	if (isTranslate) {
		if (tr >= 3)
			toRight = false;
		if (tr <= -3)
			toRight = true;

		if (toRight)
			tr += 0.1;
		else
			tr -= 0.1;
	}
	if (isRotate) {
		if (spin > 360)
			spin = spin - 360;
		else
			spin += 1.0;
	}
	Sleep(100); //ngừng 1/100 giây mỗi lần hiển thị cho dễ nhìn
}

void drawPoints() {
	glBegin(GL_POINTS); //bắt đầu vẽ points
	
	//point thứ 1
	glColor3f(1.0, 0.0, 0.0); //thiết lập màu vẽ - (1.0, 0.0, 0.0) là màu đỏ
	glVertex2f(0.0, 0.0); //tọa độ (0.0, 0.0) là ngay gốc tọa độ
	//point thứ 2
	glColor3f(1.0, 1.0, 0.0); //thiết lập màu vẽ - (1.0, 1.0, 0.0) là màu vàng
	glVertex2f(1.0, 0.0);
	//point thứ 3
	glColor3f(1.0, 1.0, 1.0); //thiết lập màu vẽ - (1.0, 1.0, 1.0) là màu trắng
	glVertex2f(0.5, 0.5);
	
	glEnd(); //kết thúc vẽ
}

void drawLines() {
	glBegin(GL_LINES); //bắt đầu vẽ lines
	
	//GL_LINES thứ 1
	glColor3f(1.0, 0.0, 0.0); //thiết lập màu vẽ - (1.0, 0.0, 0.0) là màu đỏ
	glVertex2f(0.0, 0.0); //tọa độ đỉnh 1
	glVertex2f(1.0, 0.0); //tọa độ đỉnh 2
	
	//GL_LINES thứ 2
	glColor3f(1.0, 1.0, 1.0); //thiết lập màu vẽ - (1.0, 1.0, 1.0) là màu trắng
	glVertex2f(2.0, -1.0); //tọa độ đỉnh 1
	glVertex2f(-2.0, -2.5); //tọa độ đỉnh 2
	
	glEnd(); //kết thúc vẽ
}

void drawLineStrip() {
	glBegin(GL_LINE_STRIP);
	
	glColor3f(1.0, 0.0, 0.0); //thiết lập màu vẽ - (1.0, 0.0, 0.0) là màu đỏ
	glVertex2f(-2.0, -2.0); //tọa độ đỉnh 1
	glVertex2f(0.0, 0.0); //tọa độ đỉnh 2
	glVertex2f(-2.0, 2); //tọa độ đỉnh 3
	
	glEnd(); //kết thúc vẽ
}

void drawLineLoop() {
	glBegin(GL_LINE_LOOP); //chỉ khác code GL_LINE_STRIP chỗ này
	
	glColor3f(1.0, 0.0, 0.0); //thiết lập màu vẽ - (1.0, 0.0, 0.0) là màu đỏ
	glVertex2f(-2.0, -2.0); //tọa độ đỉnh 1
	glVertex2f(0.0, 0.0); //tọa độ đỉnh 2
	glVertex2f(-2.0, 2); //tọa độ đỉnh 3
	
	glEnd(); //kết thúc vẽ
}

void drawTriangles() {
	glBegin(GL_TRIANGLES);
		
	//Tam giác thứ 1
	glColor3f(1.0, 0.0, 0.0); //thiết lập màu vẽ - (1.0, 0.0, 0.0) là màu đỏ
	glVertex2f(-2.0, -1.0); //tọa độ đỉnh 1
	glVertex2f(0.0, 0.0); //tọa độ đỉnh 2
	glVertex2f(0.0, 2.5); //tọa độ đỉnh 3
	//Tam giác thứ 2
	glColor3f(0.3, 0.4, 0.5);
	glVertex2f(2.0, -2.0); //tọa độ đỉnh 1
	glVertex2f(2.0, 0.0); //tọa độ đỉnh 2
	glVertex2f(2.8, 2.5); //tọa độ đỉnh 3
	
	glEnd(); //kết thúc vẽ
}

void drawTriangleStrip() {
	glBegin(GL_TRIANGLE_STRIP);
	
	glColor3f(1.0, 0.0, 0.0); //thiết lập màu vẽ
	glVertex2f(-1.5, 2.0); //tọa độ đỉnh 1
	glVertex2f(-3.0, -1.0); //tọa độ đỉnh 2
	glVertex2f(0.0, 1.6); //tọa độ đỉnh 3
	//
	//glColor3f(0.0, 0.0, 1.0); //chèn màu mới vô giữa cho nó đẹp
	glVertex2f(0.0, -2.0); //tọa độ đỉnh 4
	glVertex2f(1.5, 1.6); //tọa độ đỉnh 5
	glVertex2f(3.0, -2.0); //tọa độ đỉnh 6
	
	glEnd(); //kết thúc vẽ
}

void drawTriangleFan() {
	glBegin(GL_TRIANGLE_FAN);
	
	glColor3f(1.0, 0.0, 0.0); //thiết lập màu vẽ
	glVertex2f(-3.0, 0.0); //tọa độ đỉnh 1 - đỉnh gốc, có cạnh đến tất cả các đỉnh còn lại
	//glColor3f(0.5, 1.0, 1.0); //chèn màu mới vô giữa cho nó đẹp
	glVertex2f(-1.0, 3.0); //tọa độ đỉnh 2
	//glColor3f(0.0, 0.1, 1.0); //chèn màu mới vô giữa cho nó đẹp
	glVertex2f(2.0, 2.0); //tọa độ đỉnh 3
	//glColor3f(0.0, 1.0, 0.0); //chèn màu mới vô giữa cho nó đẹp
	glVertex2f(2.5, -0.5); //tọa độ đỉnh 4
	//glColor3f(0.0, 0.5, 0.5); //chèn màu mới vô giữa cho nó đẹp
	glVertex2f(1.0, -3.0); //tọa độ đỉnh 5
	//glColor3f(0.4, 0.3, 0.0); //chèn màu mới vô giữa cho nó đẹp
	glVertex2f(-2.5, -2.5); //tọa độ đỉnh 6

	glEnd(); //kết thúc vẽ
}

void drawQuads() {
	glBegin(GL_QUADS);
	
	//Tứ giác thứ 1
	glColor3f(1.0, 0.0, 0.0); //thiết lập màu vẽ
	glVertex2f(0.0, 0.0); //tọa độ đỉnh 1
	glColor3f(0.0, 1.0, 0.0); //chèn màu mới vô giữa cho nó đẹp
	glVertex2f(-1.0, 2.0); //tọa độ đỉnh 2
	glColor3f(0.0, 0.0, 1.0); //chèn màu mới vô giữa cho nó đẹp
	glVertex2f(1.0, 2.0); //tọa độ đỉnh 3
	glColor3f(0.0, 1.0, 0.0); //chèn màu mới vô giữa cho nó đẹp
	glVertex2f(2.0, 0.0); //tọa độ đỉnh 4
	//Tứ giác thứ 2
	glColor3f(0.0, 1.0, 0.5); //thiết lập màu vẽ
	glVertex2f(1.0, -2.0); //tọa độ đỉnh 1
	glVertex2f(-1.0, -2.0); //tọa độ đỉnh 2
	glVertex2f(-2.0, 0.0); //tọa độ đỉnh 3
	glVertex2f(-1.0, -0.2); //tọa độ đỉnh 4
	
	glEnd(); //kết thúc vẽ
}

void drawQuadStrip() {
	glBegin(GL_QUAD_STRIP);
	
	glColor3f(0.05, 0.4, 0.6); //thiết lập màu vẽ
	glVertex2f(-3.5, 2.0); //tọa độ đỉnh 1
	glVertex2f(-3.5, -2.0); //tọa độ đỉnh 2
	glVertex2f(-1.5, 1.0); //tọa độ đỉnh 3
	glVertex2f(-1.0, -1.0); //tọa độ đỉnh 4
	glVertex2f(1.5, 1.5); //tọa độ đỉnh 5
	glVertex2f(2.5, -2.0); //tọa độ đỉnh 6
	glVertex2f(2.8, 2.5); //tọa độ đỉnh 7
	glVertex2f(3.8, -1.8); //tọa độ đỉnh 8
	
	glEnd(); //kết thúc vẽ
}

void drawPolygon() {
	glBegin(GL_POLYGON);
	
	glColor3f(1.0, 0.0, 0.0); //thiết lập màu vẽ
	glVertex2f(0.0, 0.0); //tọa độ đỉnh 1

	glColor3f(0.0, 1.0, 0.0); //thiết lập màu vẽ
	glVertex2f(-1.0, 2.0); //tọa độ đỉnh 2

	glColor3f(0.0, 0.0, 1.0); //thiết lập màu vẽ
	glVertex2f(1.0, 2.0); //tọa độ đỉnh 3

	glColor3f(0.0, 1.0, 0.0); //thiết lập màu vẽ
	glVertex2f(2.0, 0.0); //tọa độ đỉnh 4

	glColor3f(1.0, 0.0, 0.0); //thiết lập màu vẽ
	glVertex2f(1.0, -2.0); //tọa độ đỉnh 5

	glColor3f(0.0, 1.0, 0.0); //thiết lập màu vẽ
	glVertex2f(-1.0, -2.0); //tọa độ đỉnh 6

	glColor3f(0.0, 0.0, 1.0); //thiết lập màu vẽ
	glVertex2f(-2.0, 0.0); //tọa độ đỉnh 7

	glEnd(); //kết thúc vẽ
}

/* 
* Hàm thực hiện các thao tác bàn phím
*/
void OnKeyDown(unsigned char key, int x, int y) {
	switch (key) {
	//nhấn r để thay đổi trạng thái quay
	case 'r':
		isRotate = !isRotate;
		break;

	//nhấn t để thay đổi trạng thái dịch
	case 't':
		isTranslate = !isTranslate;
	break;

	default:
		break;
	}
}

/*
* Hàm thực hiện các thao tác chuột
*/
void OnClick(int button, int state, int x, int y) {
	if (button == GLUT_LEFT_BUTTON && state == GLUT_UP) //chuột trái
		isRotate = !isRotate; //thay đổi trạng thái quay
	if (button == GLUT_RIGHT_BUTTON && state == GLUT_UP) //chuột phải
		isTranslate = !isTranslate; //thay đổi trạng thái dịch
}

/*
* Các thao tác cần làm khi window bị thay đổi kích thước
*/
void ReShape(int width, int height) {
	glViewport(0, 0, width, height); //thay đổi viewport
	glMatrixMode(GL_PROJECTION);
	glLoadIdentity();
	glOrtho(-5.0, 5.0, -5.0, 5.0, -1.0, 1.0);
}

/*
* Hàm thực hiện các khởi tạo
*/
void Init() {
	glClearColor(0.0, 0.0, 0.0, 0.0); //chọn màu nền - (0.0, 0.0, 0.0, 0.0 là màu đen)
	glShadeModel(GL_SMOOTH); //GL_SMOOTH: chế độ hòa trộn màu; GL_FLAT: chỉ hiển thị màu cuối cùng được truyền vào
}