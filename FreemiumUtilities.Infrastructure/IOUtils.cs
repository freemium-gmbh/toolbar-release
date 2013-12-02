﻿using System.IO;

namespace FreemiumUtilities.Infrastructure
{
	public static class IOUtils
	{
		/// <summary>
		/// check if specific file is accessible
		/// </summary>
		/// <param name="file"></param>
		/// <returns></returns>
		public static bool IsFileLocked(FileInfo file)
		{
			FileStream stream = null;
			try
			{
				stream = file.Open(FileMode.Open, FileAccess.ReadWrite, FileShare.None);
			}
			catch (IOException)
			{
				//the file is unavailable because it is:            
				//still being written to           
				//or being processed by another thread         
				//or does not exist (has already been processed)     
				return true;
			}
			finally
			{
				if (stream != null)
					stream.Close();
			}
			//file is not locked    
			return false;
		}
	}
}