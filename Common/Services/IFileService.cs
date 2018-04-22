/**
 * File name: IFileService.cs 
 * Author: Mosfiqur.Rahman
 * Date: 1/17/2010 3:34:15 PM format: MM/dd/yyyy
 * 
 * 
 * Modification history:
 * Name				Date					Desc
 * 
 *  
 * Version: 1.0
 * */

using System.ServiceModel;
namespace Common.Services
{
    [ServiceContract]
    public interface IFileService
    {
        [OperationContract]
        byte[] GetFile(string fileName);
    }
}
