#include"StdAfx.h" 
#include"ClassNative.h"  
CClassNative::CClassNative(void)
{  //����  
	menber=1;  
}   

CClassNative::~CClassNative(void) { }

//���Ǳ���C++��ʵ�ֵ���������  
int CClassNative::menderFuncSub(int a,int b) 
{  
	return a-b;  
}