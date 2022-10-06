using System.Diagnostics;

namespace DeWPF
{
    // Une face d'un objet de hasard
    public class Face : IFace
    {
        public int Valeur { get; }

        public string Nom { get; }

        public Face(int v, string nom)
        {
            Valeur = v;
            Nom = nom;

            // Assertion de débogage
            Debug.Assert(Nom == nom, "Valide que [Nom] a bien reçu le string d'entrée.");
        }
    }
}
