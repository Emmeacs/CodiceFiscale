using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CodiceFiscale.Models
{
	public class DomainModel
	{
		List<char> vocali = new List<char> {'A','E','I','O','U', 'a','e','i','o','u' };
		public string Cognome(string cognome)
		{
			List<string> consonanti = new List<string>();
			char[] parola = cognome.ToCharArray();
			for(int i = 0; i < parola.Length; i++) {
				if(!IsVowel(parola[i])) {
					consonanti.Add(parola[i].ToString());
					if(consonanti.Count == 3) {
						return string.Join("",consonanti);
					}
				}
			}
			if(consonanti.Count < 3) {
				foreach(char element in parola) {
					if(IsVowel(element)) {
						consonanti.Add(element.ToString());
						if(consonanti.Count == 3) {
							return string.Join("",consonanti);
						}
					}
				}
			}
			if(consonanti.Count < 3) {
				consonanti.Add(('x').ToString());
				if(consonanti.Count == 3) {
					return string.Join("",consonanti);
				}
			}
			return string.Join("",consonanti);
		}
		public bool IsVowel(char c)
		{
			if(vocali.Contains(c)) {
				return true;
			} else {
				return false;
			}
		}

	}
}