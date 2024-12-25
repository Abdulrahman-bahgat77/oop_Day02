using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace oop_Day02
{
    internal struct PhoneBook
    {
        #region Attributes
        private int[] Numbers;
        private string[] Names;

        #endregion

        #region properties
        public int Size { get; }
        #endregion
        #region constructor
        public PhoneBook(int size)
        {
            Size = size;
            Names = new string[size];
            Numbers = new int[size];
        }
        #endregion

        #region methods
        public void Addperson(int postion, string Personname, int Phonenumbers)
        {
            if (Names is not null && Numbers is not null)
            {
                if (postion < Size)
                {
                    Numbers[postion] = Phonenumbers;
                    Names[postion] = Personname;
                }

            }
        }
        #endregion

        #region Getter-Setter
        //Getter
        //public int GetPersonNumber(string Personname)
        //{
        //    if (Names is not null && Numbers is not null)
        //    {
        //        for (int i = 0; i < Names.Length; i++)
        //        {
        //            if (Names[i] == Personname)
        //                return Numbers[i];
        //        }

        //    }
        //    return -1;
        //}

        //Setter
        //public void SetPersonNumber(string personnmae, int Newnumber)
        //{
        //    if (Names is not null && Numbers is not null)
        //    {
        //        for (int i = 0; i < Names.Length; i++)
        //        {
        //            if (Names[i] == personnmae)
        //            {
        //                Numbers[i] = Newnumber;
        //                break;
        //            }

        //        }
        //    }
        //}
        #endregion

            #region indexer
  //      public int this[string name]
  //      {
  //          get
  //          {
  //              if (Names is not null && Numbers is not null)

  //                  for (int i = 0; i < Names.Length; i++)

  //                      if (Names[i] == name)
  //                          return Numbers[i];


  //              return -1;
  //          }

  //          set
  //          {
  //              if (Names is not null && Numbers is not null)
  //              {
  //                  for (int i = 0; i < Names.Length; i++)
  //                  {
  //                      if (Names[i] == name)
  //                      {
  //                          Numbers[i] = value;
  //                          break;
  //                      }

  //                  }

  //              }
  //          }

          
  //}
     
  //      public string this[int index]
  //      {
  //          get
  //          {
  //              return $"{index}:: {Names[index]}:: {Numbers[index]}";
  //          }
            
            
  //      } 
        #endregion



    }
}

