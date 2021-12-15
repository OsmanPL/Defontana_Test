using System;
using Defontana_Test1.Clases;
using System.Collections.Generic;

namespace Defontana_Test1
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente();

            List<Organismo> organismos = cliente.ListarOrganismos().GetAwaiter().GetResult();

            NodoOrganismo raiz = new NodoOrganismo();
            raiz.childs = addChilds(organismos, 0);



            Console.WriteLine("\n");
            foreach (NodoOrganismo nodo in raiz.childs)
            {
                Console.Write(printTree(nodo, ""));
            }

            Console.ReadLine();
        }

        public static List<NodoOrganismo> addChilds(List<Organismo> organismos, int i)
        {
            List<NodoOrganismo> childs = new List<NodoOrganismo>();
            foreach (Organismo orga in organismos)
            {
                if (orga.Parent == i)
                {
                    NodoOrganismo child = new NodoOrganismo();
                    child.organimso = orga;
                    child.childs = addChilds(organismos, orga.ID);
                    childs.Add(child);
                }
            }
            return childs;
        }

        public static String printTree(NodoOrganismo nodo, String sangria)
        {
            String texto = "";
            String gsangria = sangria;
            texto += sangria+ "ID: " + nodo.organimso.ID + " Name: " + nodo.organimso.Name + " Parent: " + nodo.organimso.Parent + "\n";

            foreach (NodoOrganismo nodoorga in nodo.childs)
            {
                sangria = "|    "+sangria;
                texto += printTree(nodoorga, sangria);
                sangria = gsangria;
            }

            return texto;
        }
    }
}
