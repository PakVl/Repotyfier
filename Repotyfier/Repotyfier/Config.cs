using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repotyfier
{
    class Config
    {
        /// <summary>
        /// Запускать программу при старте системы или нет
        /// </summary>
        public bool startProgramWithSystem;
        /// <summary>
        /// Промежуток времени в мнутах между опросами репозиториев
        /// </summary>
        private int timeOfRefrashInterval;
        /// <summary>
        /// Время задержики сообщения на экране в секундах
        /// </summary>
        private int timeOfMessageDelay;
        /// <summary>
        /// Список репозиториев
        /// </summary>
        public List<Repository> listOfRepositories;

        /// <summary>
        /// Конструктор 
        /// </summary>
        public Config()
        {
            startProgramWithSystem = false;
            listOfRepositories = new List<Repository>();
        }

        /// <summary>
        /// Свойство задающее промежуток времени в мнутах между опросами репозиториев
        /// </summary>
        public int TimeOfRefrashInterval
        {
            get
            {
                return timeOfRefrashInterval / 60000;
            }
            set
            {
                timeOfRefrashInterval = value * 60000;
            }
        }

        /// <summary>
        /// Свойство задающее и возвращающее время задержики сообщения на экране в секундах
        /// </summary>
        public int TimeOfMessageDelay
        {
            get
            {
                return timeOfMessageDelay / 1000;
            }
            set
            {
                timeOfMessageDelay = value * 1000;
            }
        }


        //пробегает список находя совпадающее имя репозитория

        /// <summary>
        /// Принимает имя репозитория возвращая объект клсса Repository с данными о нем
        /// </summary>
        /// <param name="name"> Имя репозитория</param>
        /// <returns></returns>
        public Repository GetRepository(string name)
        {
            Repository repos = new Repository();

            if (listOfRepositories != null)
            {
                foreach(Repository repository in listOfRepositories)
                {
                    if(repository.nameOfRepository == name)
                    {
                        repos = repository;
                    }
                }
            }

            return repos;
        }

        /// <summary>
        /// Принимая данные о репозитории, добавляя их в список объектов класса Repository
        /// </summary>
        /// <param name="user">Имя пользователя сервера</param>
        /// <param name="adress">ip адрес сервера или доменный </param>
        /// <param name="remoteWay">Адрес удаленного репозитория</param>
        /// <param name="lockalWay">Адрес локального репозитоория</param>
        public void SetRepository(string user, string adress, string remoteWay, string lockalWay)
        {
            listOfRepositories.Add(new Repository(user, adress, remoteWay, lockalWay));
        }
    }
}
