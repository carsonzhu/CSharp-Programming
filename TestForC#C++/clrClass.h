#pragma once
#include "ClassNative.h"

//���Ǹ��й�C++�����ڶ�C++���ش�����ͺ����Ƚ��з�װ����C#��ʹ��
public ref class clrClass //��������Ϊ public���������ڳ����в��ɼ����ؼ��� ref ��ʾ����һ���й��࣬������Ϊ�м�����
{
public:
	clrClass(void);

	int menber;//�����Ա����CClassNative��Ĺ�����Ա����ʵ��ֻ��Ҫ��װ������Ա�͹�����Ա������˽�еİ�װû�����壬Ҳ��װ���ˣ�
	int menderFuncSub(int a, int b);//�����Ա������װCClassNative��Ĺ�����Ա����
	int menberFuncAdd(int a, int b);//���Ա������װC���� int Add(int a,int b)

private:
	CClassNative * classNative;//����һ��������ʵ�� (�ڹ��캯����ʵ����������������Ϊ������clrClass �С��̳С�CClassNative�Ĺ�����Ա)
};
