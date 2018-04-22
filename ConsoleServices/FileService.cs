/**
 * File name: FileService.cs 
 * Author: Mosfiqur.Rahman
 * Date: 1/17/2010 3:38:00 PM format: MM/dd/yyyy
 * 
 * 
 * Modification history:
 * Name				Date					Desc
 * 
 *  
 * Version: 1.0
 * */

#region Using Directives

using System;
using Common.Services;
using System.IO;

#endregion

namespace ConsoleServices
{
    /// <summary>
    /// Summary of this class.
    /// </summary>
    public class FileService:IFileService
    {
        #region Member Variables

        #endregion

        #region Constructors

        public FileService()
        {
        }

        #endregion

        #region Properties

        #endregion

        #region Methods

        #endregion

        #region IFileService Members

        public byte[] GetFile(string fileName)
        {
            var fileNameWithPath = AppDomain.CurrentDomain.BaseDirectory + "..\\..\\Files\\" + fileName;
            fileNameWithPath = Path.GetFullPath(fileNameWithPath);
            if(File.Exists(fileNameWithPath))
            {
                return File.ReadAllBytes(fileNameWithPath);
            }
            throw new FileNotFoundException(string.Format("The file {0} doesn't exists.", fileName));
        }

        #endregion
    }// end of class
}// end of namespace
