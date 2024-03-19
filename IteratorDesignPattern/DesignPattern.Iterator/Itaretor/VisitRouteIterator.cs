namespace DesignPattern.Iterator.Itaretor
{
    public class VisitRouteIterator : IIterator<VisitRoute>
    {
        private VisitRouteMover visitRouteMover;

        public VisitRouteIterator(VisitRouteMover visitRouteMover)
        {
            this.visitRouteMover = visitRouteMover;
        }

        private int currentIndex = 0;

        public VisitRoute CurrentItem { get; set; }

        public bool NextLocation()
        {
            if (currentIndex < visitRouteMover.VisitRouteCount) { CurrentItem = visitRouteMover.visiRoutes[currentIndex++]; return true; }
            else { return false; }
        }
    }
}
