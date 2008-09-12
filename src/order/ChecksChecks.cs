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

        /// <summary>Count the record entries that pass the check.</summary>
        public static long CountRecordMatches(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (!((double)count == (9.42 * 6.2)))
                {
                    count = (count + 3) ^ sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
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
