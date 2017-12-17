#pragma once
class CClassNative
{ public: 
	CClassNative(void);  
	~CClassNative(void);    
	int menber;//用于导出的成员   
	int menderFuncSub(int a,int b);//用于导出的成员函数，实现算术减法 
};