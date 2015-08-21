using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

/// <summary>
/// ################################################################
///  EXPERIMENTAL HELPER IMPLEMENTATION
/// ################################################################
/// </summary>
namespace WindowsPhoneUWP.UpgradeHelpers
{
    internal class SortedLocaleGrouping
    {
        private CultureInfo _ci;
        private string[] _groupNames;

        public SortedLocaleGrouping(CultureInfo ci)
        {
            this._ci = ci;

            this._groupNames = "abcdefghijklmnopqrstuvwz".Select(x => x.ToString()).ToArray();
        }

        public IEnumerable<string> GroupDisplayNames {
            get
            {
                return this._groupNames;
            }
        }

        internal int GetGroupIndex(string aString)
        {
            int index = -1;
            if (aString.Length > 0)
            {
                for (int tmpIndex = 0; tmpIndex < this._groupNames.Length; tmpIndex++)
                {
                    if (aString.StartsWith(_groupNames[tmpIndex], StringComparison.CurrentCultureIgnoreCase))
                    {
                        index = tmpIndex;
                        break;
                    }
                }               
            }
            return index;

        }
    }
}