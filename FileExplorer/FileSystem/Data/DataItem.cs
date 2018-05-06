﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileExplorer.FileSystem.Data
{
    public class DataItem
    {
        public DataType Type { get; set; }

        public string FullPath { get; set; }

        public string Name { get { return Type == DataType.Drive ? FullPath : DirectoryStructure.GetFileOrFolderName(this.FullPath); } }

    }
}
