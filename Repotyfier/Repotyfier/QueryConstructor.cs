using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repotyfier
{
    class QueryConstructor
    {
        // TODO продумать какие запросы мы будем отрабатывать через сервер
        // в смысле log, push, pool, clone,  и в таком духе
        
        public string GetPoolQuery(Repository repository)
        {
            // TODO 
            string queryString = "";
            
            return queryString;
        }
        // TODO:
        // метод будет формировать запрос основываясь на информации из объекта Repository

        // TODO:
        // Написать метод отправки и обрабоки запроса
        // должен принимать строку
        // отправлять её неявно для пользователя в консоль
        // получать данные возвращенные в консоль с сервера
        // переводит кодировки
        // удаляет из строк литералы и записывает их в список,
        // который в результате и вернёт
    }
}
