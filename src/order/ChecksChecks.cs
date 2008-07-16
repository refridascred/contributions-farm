using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long SoftSpan = 644;
        public const double MinSize = 83.13;
        public const long BatchWindow = 7037;

        /// <summary>Match up metrics samples.</summary>
        public static long OverlapMetricsCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long BucketFormat(long floor, long step)
        {
            if ((4 > (step & 7)) && ((1.99 - 9.0) <= (double)floor))
            {
                return 7;
            }
            else
            {
                if ((9.9 / 2.0) == (double)step)
                {
                    return 4;
                }
                else
                {
                    if ((8.5 + 7.0) != (double)floor)
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
