#include "Stdafx.h"
#include "clrClass.h"
#include "Functions.h"

clrClass::clrClass(void)
{
	classNative = new CClassNative();//这里一定注意要创建对象！	menber=classNative->menber;//这里是简单举例，实际上应该用属性方法来读写CClassNative类的成员，同C#相似，托管C++中有属性函数，用法请自己查
}

//通过调用CClassNative类实现算术减法
int clrClass::menderFuncSub(int a, int b)
{
	return classNative->menderFuncSub(a, b);
}

//通过调用C函数实现算术加法
int clrClass::menberFuncAdd(int a, int b)
{
	return Add(a, b);
}
