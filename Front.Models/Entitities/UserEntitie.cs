﻿namespace WepApp.Core.Entities
{
    public class UserEntitie
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public bool ReadList { get; set; } = false;
        public bool AddUser { get; set; } = false;
        public bool DeleteUser { get; set; } = false;
        public bool ModifyUser { get; set; } = false;
        public bool ImportList { get; set; } = false;
        public bool ExportList { get; set; } = false;
    }
}
