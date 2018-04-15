﻿using FileManagerCL.Helpers;
using FileManagerCL.Implementations;
using FileManagerCL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace FileManagerTest
{
    public class XMLReaderTest
    {
        [Fact]
        public void XMLFileRead_existingFile_FileContent()
        {
            IXMLFileReader fileReader = new XMLFileReader();

            string filePath = @"C:\Users\Marwen\Downloads\book.xml";

            Assert.NotEmpty(fileReader.readXMLFile(filePath));
        }

        [Fact]
        public void BaseRoleXMLFileRead_existingFile_FileContent()
        {
            ISecureFilerReader fileReader = new XMLFileReader();

            string filePath = @"C:\Users\Marwen\Downloads\book.xml";

            Assert.NotEmpty(fileReader.RoleBasedFileRead(filePath,ApplicationRoles.admin));
        }
    }
}
