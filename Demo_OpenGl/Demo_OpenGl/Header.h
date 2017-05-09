#include <glut.h>
#include <gl/GL.h>
#include <gl/GLU.h>
#include <windows.h>
#include <iostream>
using namespace std;

/* Hàm thực hiện vẽ lên window,
demo vẽ các hình học cơ bản, phép quay và phép dịch */
void RenderScene_1();

/* Hàm thực hiện vẽ lên window,
demo xử lý chuột và bàn phím */
void RenderScene_2();

/* Các thao tác cần làm khi window bị thay đổi kích thước */
void ReShape(int width, int height);

/* Hàm thực hiện các thao tác bàn phím */
void OnKeyDown(unsigned char key, int x, int y);

/* Hàm thực hiện các thao tác chuột */
void OnClick(int button, int state, int x, int y);

void Init(); //Hàm thực hiện các khởi tạo

void drawPoints();
void drawLines();
void drawLineStrip();
void drawLineLoop();
void drawTriangles();
void drawTriangleStrip();
void drawTriangleFan();
void drawQuads();
void drawQuadStrip();
void drawPolygon();
