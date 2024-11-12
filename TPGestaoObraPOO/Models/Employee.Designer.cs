using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPGestaoObraPOO.Models
 public abstract class Employee
{

    #region Private Properties
    private int id { get; set; }
    private string nif;
    private string address;
    private string phone;
    private string name;
    private string email;
    #endregion

    #region Public Properties
    public string Name
    {
        get { return name; }
        set
        {
            if (!string.IsNullOrEmpty(value))
            {
                name = value;
            }
        }
    }

    public string Email
    {
        get { return email; }
        set { email = value; }
    }
    #endregion

    #region Constructor
    public Person(string name, string email)
    {
        Name = name;
        Email = email;
    }

    public Person(int id, string name)
    {
        this.id = id;
        Name = name;
    }
    #endregion

    #region Methods

    public abstract string GetIdentification();

    // Método privado para validar o NIF 
    private bool ValidateNIF(string nif)
    {
        return nif.Length == 9 && long.TryParse(nif, out _);
    }

    // Método privado para validar o Telefone
    private bool ValidatePhone(string phone)
    {
        return phone.Length >= 9 && phone.Length <= 15;
    }

    #endregion
}
}