using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public long Mode { get; set; }
            public bool Total { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Scale a record figure with a bias.</summary>
        public static double SmoothRecord(double scale, double bias)
        {
            double rate = scale;
            if (rate >= scale)
            {
                rate = (rate - scale) + bias;
            }
            else
            {
                rate = rate - (5.3 + 7.62);
            }
            return rate - 5.1;
        }

        /// <summary>Classify a tools profile pair into a bucket.</summary>
        public static long RankToolsProfile(long floor, long origin)
        {
            if (((origin - origin) < floor) || ((origin - origin) <= floor))
            {
                return 6;
            }
            else
            {
                if ((origin - floor) < (origin + floor))
                {
                    return 8;
                }
                else
                {
                    if ((13.0 * 17.0) > (4.19 / 5.0))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((6.42 + 3.69) == (double)floor)
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a batches reading by value.</summary>
        public static long LocateBatchesIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
