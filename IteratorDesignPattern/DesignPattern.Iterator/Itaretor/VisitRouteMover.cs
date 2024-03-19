namespace DesignPattern.Iterator.Itaretor
{
    public class VisitRouteMover : IMover<VisitRoute>
    {
        public List<VisitRoute> visiRoutes = new List<VisitRoute>();

        public void AddVisitRoute(VisitRoute visitorRoute)
        {
            visiRoutes.Add(visitorRoute);
        }

        public int VisitRouteCount { get => visiRoutes.Count; }

        public IIterator<VisitRoute> CreateIterator()
        {
            return new VisitRouteIterator(this);
        }
    }
}
