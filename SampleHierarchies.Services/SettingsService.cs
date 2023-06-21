using Newtonsoft.Json;
using SampleHierarchies.Interfaces.Data;
using SampleHierarchies.Interfaces.Services;
using System.Diagnostics;

namespace SampleHierarchies.Services;

/// <summary>
/// Settings service.
/// </summary>
public class SettingsService : ISettingsService
{
    #region ISettings Implementation

    /// <inheritdoc/>
    public ISettings? Read(string jsonPath)
    {
        //    ISettings? result;

        //    try
        //    {
        //        string jsonContent = File.ReadAllText(jsonPath);
        //        var jsonSettings = new JsonSerializerSettings()
        //        {
        //            TypeNameHandling = TypeNameHandling.Objects
        //        };
        //        result = JsonConvert.DeserializeObject<Animals>(jsonContent, jsonSettings);
        //        if (Animals is null)
        //        {
        //            result = false;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Debug.WriteLine(ex);
        //        result = false;
        //    }

        ISettings? result = null;
        return result;

    }



    /// <inheritdoc/>
    public void Write(ISettings settings, string jsonPath)
    {
        try
        {
            var jsonSettings = new JsonSerializerSettings();
            string jsonContent = JsonConvert.SerializeObject(settings);
            string jsonContentFormatted = jsonContent.FormatJson();
            File.WriteAllText(jsonPath, jsonContentFormatted);
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex);
        }
    }

    #endregion // ISettings Implementation
}