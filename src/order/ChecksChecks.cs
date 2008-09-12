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

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long FindProfileIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

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
