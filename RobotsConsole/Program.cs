using Robots;

RobotMobile android = new RobotMobile("C3PO", 0, 0, 5, new RobotsPoint(30, 30) );


android.Forwad(5, 30);


Console.WriteLine(android.ToMove(new RobotsPoint(10, 10)));
Console.WriteLine(android.ShowPosition());
Console.WriteLine(android.Start());
Console.WriteLine(android.Stop());

android.Clean();