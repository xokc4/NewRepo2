using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfBot
{
    class MessageLogin
    {
        public string Time { get; set; }//время

        public long Id { get; set; }//айди

        public string Msg { get; set; }//сообщение

        public string FirstName { get; set; }//имя пользователя
        public long FileId { get; set; }//айди файла
        public string FileName { get; set; }//имя файла

        public MessageLogin(string Time, string Msg, string FirstName, long Id)//вывод сообщения
        {
            this.Time = Time;
            this.Msg = Msg;
            this.FirstName = FirstName;
            this.Id = Id;
        }

       
    }
}
