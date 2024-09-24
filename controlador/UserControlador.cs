using formulario.entidad;
using formulario.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formulario
{
    
    public class UserControlador
    {
        private UserModel model;
    public UserControlador() 
        {
        model = new UserModel();

        }
    public int Create(EUser user)
        {
            user.Password=hashPassword(user.Password);

            return model.create(user);

        }
    public List<EUser> GetAll()
        {
            return model.readAll();
        }
    public int Update(EUser user)

        {   
            EUser user2 = model.findById(user.Id);
            if (user.Password != "")
            {
                user.Password = hashPassword(user.Password);


            }
            else
            {
                user.Password = user2.Password;
            }

            
            return model.update(user);

        }
        public int Delete(EUser user)
        {
            return model.delete(user);
        }

    private string hashPassword(string password)
        {
            string hash = "";

            hash = BCrypt.Net.BCrypt.HashPassword(password, workFactor:10);
            return hash;
        }

    public bool login(string username, string password)
        {
            EUser user = model.findByUsername(username);


            if (user == null)
            {
                return false;
            }
            if (BCrypt.Net.BCrypt.Verify(password, user.Password))
            {
                return true;
            }
            else
            {
                return false;
            }
            //if (user.Username !=null)
            //{
            //    if (BCrypt.Net.BCrypt.Verify(password, user.Password))
            //    {
            //        return true;
            //    }
            //    else
            //    {
            //   return false;
            //    }


            //}

            //    else
            //    {
            //    return false;

            //}
        }
    }
   
}
