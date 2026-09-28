using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRT.Core.SRTFile
{
    public class ZipHelper
    {
        /// <summary>
        /// Unzips a zip file to a specified destination folder.
        /// </summary>
        /// <param name="zipFilePath">The path to the zip file.</param>
        /// <param name="destinationPath">The path to the destination folder.</param>
        /// <param name="overwrite">Whether to overwrite existing files in the destination folder. Defaults to false.</param>
        /// <returns>True if the unzipping was successful, false otherwise.</returns>
        public static bool UnzipFile(string zipFilePath, string destinationPath, bool overwrite = false)
        {
            try
            {
                // Ensure the destination directory exists.  Create it if it doesn't.
                if (!Directory.Exists(destinationPath))
                {
                    Directory.CreateDirectory(destinationPath);
                }

                // Use the ZipFile.ExtractToDirectory method to unzip the file.
                ZipFile.ExtractToDirectory(zipFilePath, destinationPath, overwrite);

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error unzipping file: {ex.Message}"); // Log the error.  Important for debugging.
                return false;
            }
        }
    }
}
