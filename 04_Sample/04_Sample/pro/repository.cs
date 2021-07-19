using IdentityModel.Client;
using System.Reflection;

namespace _04_Sample.pro
{
    public class repository
    {
        public bool UpdateInfo(Model.info model)
        {
            bool result = false;
            PropertyInfo[] column = model.GetType().GetProperties();
            string SQL = string.Format($@"UPDATE TB_user {0} SET WHERE id = {model.ID}", column);
            return result;
        }
    }
}