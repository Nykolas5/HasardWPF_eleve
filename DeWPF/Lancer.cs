using System.Diagnostics;

namespace DeWPF
{
    // Un lancer d'un objet de hasard
    public class Lancer
    {
        public ObjetHasard Objet { get; }
        public Face Face { get; }

        public Lancer(ObjetHasard objet, Face face)
        {
            Objet = objet;
            Face = face;
        }
    }
}
