#include "Stdafx.h"
#include "clrClass.h"
#include "Functions.h"

clrClass::clrClass(void)
{
	classNative = new CClassNative();//����һ��ע��Ҫ��������	menber=classNative->menber;//�����Ǽ򵥾�����ʵ����Ӧ�������Է�������дCClassNative��ĳ�Ա��ͬC#���ƣ��й�C++�������Ժ������÷����Լ���
}

//ͨ������CClassNative��ʵ����������
int clrClass::menderFuncSub(int a, int b)
{
	return classNative->menderFuncSub(a, b);
}

//ͨ������C����ʵ�������ӷ�
int clrClass::menberFuncAdd(int a, int b)
{
	return Add(a, b);
}
