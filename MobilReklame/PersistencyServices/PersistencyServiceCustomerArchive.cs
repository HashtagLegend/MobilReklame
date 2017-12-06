using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;
using Windows.UI.Popups;
using Newtonsoft.Json;

namespace MobilReklame
{
    class PersistencyServiceCustomerArchive
    {
        //private static string JsonFileName = "CustomerArchive.json";

        //public static async void SaveCustomerArchiveAsJsonAsync(ObservableCollection<Customer> customerArchive)
        //{
        //    string customerarchiveJsonString = JsonConvert.SerializeObject(customerArchive);
        //    SerializeCustomerArchiveFileAsync(customerarchiveJsonString, JsonFileName);
        //}

        //public static async Task<List<Customer>> LoadCustomerArchiveFromJsonAsync()
        //{
        //    string customerArchiveJsonString = await DeserializeCustomerArchiveFileAsync(JsonFileName);
        //    if (customerArchiveJsonString != null)
        //        return (List<Customer>)JsonConvert.DeserializeObject(customerArchiveJsonString, typeof(List<Customer>));
        //    return null;
        //}



        //private static async void SerializeCustomerArchiveFileAsync(string customerArchiveJsonString, string fileName)
        //{
        //    StorageFile localFile = await ApplicationData.Current.LocalFolder.CreateFileAsync(fileName, CreationCollisionOption.ReplaceExisting);
        //    await FileIO.WriteTextAsync(localFile, customerArchiveJsonString);
        //}


        //private static async Task<string> DeserializeCustomerArchiveFileAsync(string fileName)
        //{
        //    try
        //    {
        //        StorageFile localFile = await ApplicationData.Current.LocalFolder.GetFileAsync(fileName);
        //        return await FileIO.ReadTextAsync(localFile);
        //    }
        //    catch (FileNotFoundException ex)
        //    {
        //        MessageDialogHelper.Show("Loading for the first time? - Try Add and Save some Notes before trying to Save for the first time", "File not Found");
        //        return null;
        //    }
        //}


        //private class MessageDialogHelper
        //{
        //    public static async void Show(string content, string title)
        //    {
        //        MessageDialog messageDialog = new MessageDialog(content, title);
        //        await messageDialog.ShowAsync();
        //    }
        //}
    }
}
