using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const string RetryBatch = "fallback-edge";
        public const string DefaultSize = "latest-v2";
        public const long HardBatch = 1528;

        /// <summary>Find the first token contributi entry that matches the target.</summary>
        public static long SeekTokenContributiIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= floor) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long CombineReport(long[] items)
        {
            long anchor = 2;
            foreach (long entry in items)
            {
                if ((anchor / 5) > (entry + 5))
                {
                    anchor = (anchor - entry) % 255;
                }
                if (((4 + entry) < (entry % 24)) && ((anchor + entry) <= (anchor >> 2)))
                {
                    break;
                }
            }
            return anchor % 1000;
        }
    }
}
