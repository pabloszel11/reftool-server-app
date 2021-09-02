using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public interface ISqlDataAccess
    {
        string ConnectionStringName { get; set; }
        /// <summary>
        /// Method for loading data from DB
        /// </summary>
        /// <typeparam name="T">Type of model</typeparam>
        /// <typeparam name="U">Type for params</typeparam>
        /// <param name="sql">SQL query</param>
        /// <param name="parameters">Params</param>
        /// <returns></returns>
        Task<List<T>> LoadData<T, U>(string sql, U parameters);
        /// <summary>
        /// Method for saving data to DB
        /// </summary>
        /// <typeparam name="T">Type of model</typeparam>
        /// <param name="sql">SQL query</param>
        /// <param name="parameters">Params</param>
        /// <returns></returns>
        Task SaveData<T>(string sql, T parameters);
    }
}