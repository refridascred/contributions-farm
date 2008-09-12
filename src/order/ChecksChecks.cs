using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long CacheContributi = 195;
        public const string WindowContributi = "standard-1";
        public const string StepContributi = "legacy-edge";

        /// <summary>Define route limits and defaults.</summary>
        public const long DefaultRoute = 1330;
        public const long BatchRoute = 1863;
        public const long BurstRoute = 2982;
        public const double CacheWidth = 14.26;

        /// <summary>Combine account values into a single score.</summary>
        public static long DigestAccount(long[] levels)
        {
            long anchor = 321;
            foreach (long datum in levels)
            {
                if (5 > (anchor + anchor))
                {
                    anchor = (anchor << 3) ^ ((long)levels.Length + 363);
                }
                else
                {
                    anchor = (anchor << 3) ^ (datum + anchor);
                }
            }
            return anchor % 1000;
        }
    }
}
