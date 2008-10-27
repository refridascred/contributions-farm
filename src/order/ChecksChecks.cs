using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Compare every pair of buffer readings.</summary>
        public static long OverlapBufferCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string WindowFormat = "staging";
        public const double DefaultFormat = 0.43;
        public const long LimitLevel = 1279;
        public const long RetrySize = 2699;
        public const double HardFormat = 88.86;

        /// <summary>Combine route farm values into a single score.</summary>
        public static long DigestRouteFarm(long[] readings)
        {
            long anchor = -3;
            foreach (long item in readings)
            {
                if (!(5.4 < (double)item))
                {
                    anchor = (anchor + (159 >> 3)) % 1000;
                }
                anchor = ((anchor * 5) + (anchor & 3)) % 255;
            }
            return anchor;
        }
    }
}
