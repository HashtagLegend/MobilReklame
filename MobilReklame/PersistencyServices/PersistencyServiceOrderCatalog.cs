using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Windows.UI.Popups;
using Windows.Storage;
using System.IO;
using MobilReklame.Singleton;




namespace MobilReklame.PersistencyServices
{
    //Json.Net er downloaded til projektet via NuGet: Højreklik på projektet -> Manage NuGet Package
    class PersistencyServiceOrderCatalog
    {
        //private static string JsonOrderListFile = "OrderList.json";

        //public static async void SaveOrderListAsJsonAsync(ObservableCollection<Order> orderList)
        //{
        //    string notesJsonString = JsonConvert.SerializeObject(orderList);
        //    SerializeNotesFileAsync(notesJsonString, JsonOrderListFile);
        //}

        //public static async Task<List<Order>> LoadOrderListFromJsonAsync()
        //{
        //    string orderListJsonString = await DeserializeNotesFileAsync(JsonOrderListFile);
        //    if (orderListJsonString != null)
        //        return (List<Order>)JsonConvert.DeserializeObject(orderListJsonString, typeof(List<Order>));
        //    return null;
        //}
       

        //private static async void SerializeNotesFileAsync(string notesJsonString, string fileName)
        //{
        //    StorageFile localFile = await ApplicationData.Current.LocalFolder.CreateFileAsync(fileName, CreationCollisionOption.ReplaceExisting);
        //    await FileIO.WriteTextAsync(localFile, notesJsonString);
        //}


        //private static async Task<string> DeserializeNotesFileAsync(string fileName)
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
