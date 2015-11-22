using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repotyfier
{
    class Repository
    {
        /// <summary>
        /// Имя репозитория
        /// </summary>
        public string nameOfRepository;
        /// <summary>
        /// Пользователь удаленного репозитория
        /// </summary>
        public string userOfServer;
        /// <summary>
        /// Адрес Mercurial сервера
        /// </summary>
        public string adressOfServer;
        /// <summary>
        /// Путь к удленному репозиторию пример: /way/to/repository
        /// </summary>
        public string remoteRepositoryWay;
        /// <summary>
        /// Путь к локальному репозиторию
        /// </summary>
        public string lockalRepositoryWay;

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public Repository() { }

        /// <summary>
        /// Конструктор инициализирует поля класса, принимая данные для формирования запроса на сервер
        /// </summary>
        /// <param name="user">Имя пользователя сервера</param>
        /// <param name="adress">ip адрес сервера или доменный </param>
        /// <param name="remoteWay">Адрес удаленного репозитория</param>
        /// <param name="lockalWay">Адрес локального репозитоория</param>
        public Repository(string user, string adress, string remoteWay, string lockalWay)
        {
            userOfServer = user;
            adressOfServer = adress;
            remoteRepositoryWay = remoteWay;
            lockalRepositoryWay = lockalWay;

            int nameIndex = 0;
            for (int i = remoteRepositoryWay.Length - 1; i >= 0; i--)
            {
                if (remoteRepositoryWay[i] == '/')
                {
                    nameIndex = i + 1;
                    break;
                }
            }

            for (int i = nameIndex; i < remoteRepositoryWay.Length; i++)
            {
                nameOfRepository += remoteRepositoryWay[i];
            }
        }


    }
}
