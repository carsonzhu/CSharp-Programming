using System.Windows;

namespace Wrox.ProCSharp.Delegates
{
    public class WeakCarInfoEventManager : WeakEventManager
    {
        public static void AddListener(object source, IWeakEventListener listener)
        {
            CurrentManager.ProtectedAddListener(source, listener);
        }

        public static void RemoveListener(object source, IWeakEventListener listener)
        {
            CurrentManager.ProtectedRemoveListener(source, listener);
        }

        public static WeakCarInfoEventManager CurrentManager      //静态属性CurrentManager创建了一个WeakCarInfoEventManager类型的对象（如果它不存在），并返回对该对象的引用
        {
            get
            {
                WeakCarInfoEventManager manager = GetCurrentManager(typeof(WeakCarInfoEventManager)) as WeakCarInfoEventManager;
                if (manager == null)
                {
                    manager = new WeakCarInfoEventManager();
                    SetCurrentManager(typeof(WeakCarInfoEventManager), manager);
                }
                return manager;
            }
        }

        
        protected override void StartListening(object source)     //重写：添加第一个侦听器时调用该方法
        {
            (source as CarDealer).NewCarInfo += CarDealer_NewCarInfo;
        }

        void CarDealer_NewCarInfo(object sender, CarInfoEventArgs e)
        {
            DeliverEvent(sender, e);   //把事件传递给侦听器
        }
        protected override void StopListening(object source)     //重写：删除最后一个侦听器时调用该方法
        {
            (source as CarDealer).NewCarInfo -= CarDealer_NewCarInfo;
        }
    }
}
