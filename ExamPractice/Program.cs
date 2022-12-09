namespace ExamPractice
{
    public interface IMoveable
    {
        void Move(double x, double y);
    }

    public class PolygonalChain : Segment, IMoveable
    {
        private readonly List<Point> _midPoints = new();

        public PolygonalChain(Point start, Point end) : base(start, end)
        {
        }

        public void AddMidPoint(Point midpoint) => _midPoints.Add(midpoint);

        public override double Length
        {
            get
            {
                var totalLength = 0.0;

                var tempPointList = GetAllPoints();

                for (var i = 0; i < tempPointList.Count - 1; i++)
                    totalLength += new Segment(tempPointList[i], tempPointList[i + 1]).Length;

                return totalLength;
            }
        }

        public void Move(double x, double y)
        {
            _start.Move(x,y);
            _end.Move(x,y);

            foreach (var midPoint in _midPoints) midPoint.Move(x, y);
        }

        public override string ToString() => string.Join(",", GetAllPoints());

        private List<Point> GetAllPoints()
        {
            var tempPointList = new List<Point> { _start };

            tempPointList.AddRange(_midPoints);
            tempPointList.Add(_end);

            return tempPointList;
        }
    }

    public class Segment
    {
        protected readonly Point _start;
        protected readonly Point _end;

        public Segment(Point start, Point end) => (_start, _end) = (start, end);

        public virtual double Length => Math.Sqrt(Math.Pow(_start.X - _end.X, 2) + Math.Pow(_start.Y - _end.Y, 2));

        public override string ToString() => $"{_start},{_end}";
    }

    public class Point : IMoveable
    {
        private double _x;
        private double _y;

        public double X => _x;
        public double Y => _y;

        public Point() : this(0,0) { }

        public Point(double x) : this(x,x) { }

        public Point(double x, double y) => (_x, _y) = (x, y);
        public void Move(double x, double y)
        {
            _x += x;
            _y += y;
        }

        public virtual double Distance() => Math.Sqrt(_x * _x + _y * _y);

        public override string ToString() => $"({X},{Y})";
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Point();
            var p2 = new Point(5);
            var p3 = new Point(3,4);

            var s1 = new Segment(p1, p2);
            
            Console.WriteLine(p3.Distance());

            var s = new PolygonalChain(new Point(0, 0), new Point(1, 1));
            s.AddMidPoint(new Point(1,0));

            s.Move(0,-2);


            Console.WriteLine(s.Length);

            Console.WriteLine(p1.ToString());
            Console.WriteLine(s1.ToString());
            Console.WriteLine(s.ToString());
        }
    }
}