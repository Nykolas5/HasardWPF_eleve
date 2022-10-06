using System;
using System.Diagnostics;


namespace DeWPF
{
    // Un objet de hasard
    public abstract class ObjetHasard : IObjetHasard
    {
        public static readonly Random rnd = new Random();

        public string Nom { get; }

        public Face[] Faces { get; }

        public int NbFaces => Faces.Length;

        public ObjetHasard(string nom, int nbFaces)
        {
            Nom = nom;
            Faces = new Face[nbFaces];
            CreerFaces();
        }

        protected virtual void CreerFaces()
        {
            for (int valeur = 1; valeur <= NbFaces; valeur++)
            {
                Faces[valeur-1] = new Face(valeur, valeur.ToString());
            }

            // Assertion de débogage
            Debug.Assert(Faces.Length > 0, "Valide qu'il y a bien plusieurs faces a l'object.");
        }

        public Face Lancer()
        {
            return Faces[rnd.Next(NbFaces)];
        }
    }
}
