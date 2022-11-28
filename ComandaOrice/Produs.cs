using System;
using System.Collections.Generic;
using System.Text;

namespace prjComandaOrice.ComandaOrice
{
	public class Produs
	{
		public string denumire;
		public string idprodus;
		public string idfurnizor;
		public float pret;
		public float cotaTVA;
		public string idCategoria;
		public int stoc;
		public List <Image> galerieFoto;
		public string idTabelInformatii;
		public List < Comentariu > comentarii;
	}
}
