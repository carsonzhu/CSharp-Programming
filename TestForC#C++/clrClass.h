#pragma once
#include "ClassNative.h"

//这是个托管C++类用于对C++本地代码类和函数等进行封装以在C#中使用
public ref class clrClass //必须声明为 public，否则类在程序集中不可见，关键词 ref 表示类是一个托管类，将编译为中间语言
{
public:
	clrClass(void);

	int menber;//这个成员访问CClassNative类的公共成员（事实上只需要包装公共成员和公共成员函数，私有的包装没有意义，也包装不了）
	int menderFuncSub(int a, int b);//这个成员函数包装CClassNative类的公共成员函数
	int menberFuncAdd(int a, int b);//这成员函数包装C函数 int Add(int a,int b)

private:
	CClassNative * classNative;//建立一个本地类实例 (在构造函数中实例化，这里可以理解为用于在clrClass 中“继承”CClassNative的公共成员)
};
