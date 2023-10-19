
namespace Robots
{
    public abstract class RobotAbstract
    {
        public abstract string Start();
        public string Stop()
        {
            return "Robot stop";
        }
    }
    public class Robot: RobotAbstract
    {
        public string Name { get; set; }
        protected int _positionX;
        protected int _positionY;

        #region constructeur

        public Robot(string name, int posX, int posY) {
            Name = name;
            _positionX = posX;
            _positionY = posY;
        }

        #endregion
        #region method

        public override string Start()
        {
            return "Robot start";
        }
        public void Forwad(int directionX, int directionY)
        {
            this._positionX += directionX;
            this._positionY += directionY;
        }

        public virtual string ShowPosition()
        {
            string position = "Vous êtes à la Position : " + this._positionX + "," + this._positionY;
            return position;
        }
        #endregion
    }

    public class RobotMobile : Robot, IRobotClean
    {
        public int Speed;
        private RobotsPoint _position;
        public RobotMobile(string name, int posX, int posY, int speed, RobotsPoint position) : base(name, posX, posY)
        {
            Speed = speed;
            _position = position;
        }

        public int CalculMoveDuration(RobotsPoint p1, RobotsPoint p2)
        {
            return Utils.CalculDistance(p1, p2) / Speed; 
        }

        public override string ShowPosition()
        {
            string position = "Vous êtes à la Position : " + this._positionX + "," + this._positionY;
            return position;
        }

        public void Clean()
        {
            Console.WriteLine($"Le robot mobile {Name} nettoie ");
        }

        public int ToMove(RobotsPoint position)
        {
            return Utils.CalculDistance(_position, position);
        }
    }
}