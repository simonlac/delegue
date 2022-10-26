using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegues
{
    class TrieurDeTableau
    {
        private delegate void DelegateTri(int[] tableau);
        public delegate int DelegateSomme(float param );

        private void TriAscendant(int [] tableau)
        {
            Console.WriteLine("Tri ascendant...");
            Array.Sort(tableau);
        }
        private void TriDescendant(int[] tableau)
        {
            Console.WriteLine("Tri descendant...");
            Array.Sort(tableau);
            Array.Reverse(tableau);
        }

        public void DemoTri1(int [] tableau)
        {
            Console.WriteLine("Utilisation des délégués\n");
            DelegateTri tri = TriAscendant;
            tri(tableau);
            foreach (int i in tableau)
            {
                Console.Write(i.ToString()+" ");
            }
            Console.WriteLine("\n");
            tri = TriDescendant;
            tri(tableau);
            foreach (int i in tableau)
            {
                Console.Write(i.ToString()+" ");
            }
        }
        // Factorisation du code
        private void TrierEtAfficher( int[] tableau, DelegateTri MethodeDeTri)

        {
            
            MethodeDeTri(tableau);
            foreach (int i in tableau)
            {
                Console.Write(i.ToString() + " ");
            }
            
        }
        
        public void DemoTri2(int [] tableau)
        {
            Console.WriteLine("Les délégués permettent la factorisation du code.\n");
            TrierEtAfficher( tableau, TriAscendant);
            Console.WriteLine("\n");
            TrierEtAfficher( tableau, TriDescendant);
        }
        // Utiliser une méthode anonyme
        public void demotri3(int[] tableau)
        {
            Console.WriteLine("Utilisation des méthodes anonymes\n");
            TrierEtAfficher(tableau, delegate (int [] letableau)
             {
                 Console.WriteLine("Méthode anonyme tri ascendant");
                 Array.Sort(letableau);
                 
             });
            Console.WriteLine("\n");
            TrierEtAfficher(tableau, delegate (int[] letableau)
            {
                Console.WriteLine("Méthode anonyle tri descendant ");
                Array.Sort(letableau);
                Array.Reverse(letableau);
            });
        }

        // Multicast : Délégué pointe vers plusieurs méthodes
        private void TriAscendant2(int[] tableau)
        {
            Console.WriteLine("Tri ascendant...");
            Array.Sort(tableau);
            foreach (int i in tableau)
                Console.Write(i.ToString()+" ");
            Console.WriteLine("\n");
        }
        private void TriDescendant2(int[] tableau)
        {
            Console.WriteLine("Tri descendant...");
            Array.Sort(tableau);
            Array.Reverse(tableau);
            foreach (int i in tableau) 
                Console.Write(i.ToString()+" ");
        }
        public void demotri4(int [] tableau)
        {
            Console.WriteLine("Multicast...\n");
            DelegateTri tri = TriAscendant2;
            tri += TriDescendant2;
            tri(tableau);


        }
        // Multicast avec  délégués anonymes
        public void demotri5(int[] tableau)
        {
            Console.WriteLine("Multicast avec délégués anonymes...\n");
            DelegateTri tri = delegate(int [] leTableau)
                {
                    Console.WriteLine("Tri ascendant...");
                    Array.Sort(leTableau);
                    foreach (int i in leTableau)
                        Console.Write(i.ToString() + " ");
                    Console.Write("\n");
                };
            tri += delegate(int [] leTableau)
                {
                    Console.WriteLine("Tri descendant...");
                    Array.Sort(leTableau);
                    Array.Reverse(leTableau);
                    foreach (int i in leTableau)
                        Console.Write(i.ToString() + " ");
                    Console.Write("\n");
                };
            tri(tableau);


        }

    }
}
