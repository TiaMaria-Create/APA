using System;

namespace ZooKeeperApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiate
            ZooKeeper application = new ZooKeeper();
            application.WelcomeUser();
        }
    }
}
