namespace Stoelendans
{
    internal class Stoel
    {
        // Fields (eigenschappen)
        private string _kleur;
        private int _zithoogte;

        // Constructor
        public Stoel(string ingegevenKleur, int ingegevenZithoogte)
        {
            _kleur = ingegevenKleur;
            _zithoogte = ingegevenZithoogte;
        }

        // Functions (handelingen)
        public string echoKleur()
        {
            return "De stoel is: " + _kleur;
        }

        public int getZithoogte()
        {
            return _zithoogte;
        }

        public void verstellen(int hoogte)
        {
            _zithoogte = hoogte;
        }
    }
}