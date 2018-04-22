using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.IO;

namespace Service
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени интерфейса "IServiceUpdate" в коде и файле конфигурации.
    [ServiceContract]
    public interface IServiceUpdate
    {
        [OperationContract]
        string[] getFileinfo();
        [OperationContract]
        Stream getFile(string way);
        [OperationContract]
        int LenghtFile(string way);


    }
}
