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
        private static string JsonFileName = "CustomerArchive.json";

        public static async void SaveCustomerArchiveAsJsonAsync(ObservableCollection<CustomerArchiveSingleton> customerarchive)
        {
            string customerarchiveJsonString = JsonConvert.SerializeObject(customerarchive);
            SerializeCustomerArchiveFileAsync(customerarchiveJsonString, JsonFileName);
        }

        public static async Task<List<CustomerArchiveSingleton>> LoadCustomerArchiveFromJsonAsync()
        {
            string customerarchiveJsonString = await DeserializeCustomerArchiveFileAsync(JsonFileName);
            if (customerarchiveJsonString != null)
                return (List<CustomerArchiveSingleton>)JsonConvert.DeserializeObject(customerarchiveJsonString, typeof(List<CustomerArchiveSingleton>));
            return null;
        }



        private static async void SerializeCustomerArchiveFileAsync(string customerarchiveJsonString, string fileName)
        {
            StorageFile localFile = await ApplicationData.Current.LocalFolder.CreateFileAsync(fileName, CreationCollisionOption.ReplaceExisting);
            await FileIO.WriteTextAsync(localFile, customerarchiveJsonString);
        }


        private static async Task<string> DeserializeCustomerArchiveFileAsync(string fileName)
        {
            try
            {
                StorageFile localFile = await ApplicationData.Current.LocalFolder.GetFileAsync(fileName);
                return await FileIO.ReadTextAsync(localFile);
            }
            catch (FileNotFoundException ex)
            {
                MessageDialogHelper.Show("Loading for the first time? - Try Add and Save some Notes before trying to Save for the first time", "File not Found");
                return null;
            }
        }


        private class MessageDialogHelper
        {
            public static async void Show(string content, string title)
            {
                MessageDialog messageDialog = new MessageDialog(content, title);
                await messageDialog.ShowAsync();
            }
        }
    }
}
