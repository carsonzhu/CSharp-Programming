#include"StdAfx.h" 
#include"ClassNative.h"  
CClassNative::CClassNative(void)
{  //构造  
	menber=1;  
}   

CClassNative::~CClassNative(void) { }

//这是本地C++类实现的算术减法  
int CClassNative::menderFuncSub(int a,int b) 
{  
	return a-b;  
}