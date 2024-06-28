using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuvaDePedreiroTranslator
{
    internal class LuvaDePedreiro
    {
        public LuvaDePedreiro(){}

        public string Receba(string texto)
        {

            string[] _receba = texto.Split(' ');
            List<string> _texto = _receba.ToList();
            List<string> receba = _receba.ToList();

            for(int i = 0; i < _texto.Count; i++)
            {
                if (_texto.Contains(",") && _texto.Count > 6)
                {
                    _texto.Insert(i, ", ");
                }

                if(_texto.Contains(",") && _texto.Count < 6)
                {
                    if(i == 0)
                    {
                        _texto.Insert(i + 1, ", ");
                    }

                    _texto.Insert(i - 1, ", ");
                }

                if (_texto.Contains(".") && _texto.Count > 6)
                {
                    _texto.Insert(i, ". ");
                }

                if (_texto.Contains(".") && _texto.Count < 6)
                {
                    if (i == 0)
                    {
                        _texto.Insert(i + 1, ". ");
                    }

                    _texto.Insert(i - 1, ". ");
                }

                if (_texto.Contains("!") && _texto.Count > 6)
                {
                    _texto.Insert(i, "! ");
                }

                if (_texto.Contains("!") && _texto.Count < 6)
                {
                    if (i == 0)
                    {
                        _texto.Insert(i + 1, "! ");
                    }

                    _texto.Insert(i - 1, "! ");
                }
            }

            for(int i = 0; i < receba.Count; i++)
            {
                receba.RemoveAt(i);
                receba.Add("Receba ");
            }

            for(int i = 0; i < _texto.Count; i++)
            {
                if (_texto[i] == ",") 
                {
                    receba[i].Insert(i, _texto[i]);
                }

                if (_texto[i] == ".")
                {
                    receba[i].Insert(i, _texto[i]);
                }

                if (_texto[i] == "!")
                {
                    receba[i].Insert(i, _texto[i]);
                }
            }

            string recebaPai = "";
            foreach(var item in receba) {  recebaPai += item; }
            return recebaPai;
        }

    }
}
