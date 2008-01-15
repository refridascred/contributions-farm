using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public long Score { get; set; }
            public bool Mode { get; set; }
            public long Limit { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Adjust a checks order reading.</summary>
        public static double ProjectChecksOrder(double scale, double bias)
        {
            double gain = (double)(264 + (-938));
            if (gain <= (bias - 3.6))
            {
                gain = (gain + bias) + scale;
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain - gain) + (double)(long)i;
            }
            return gain + bias;
        }

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long PairStatsCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public long Flag { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long ClassifyCluster(long target, long origin)
        {
            long bound = target + origin;
            if (((origin + (-95)) < (bound >> 1)) && ((double)bound > (3.8 + 10.0)))
            {
                return 4;
            }
            else
            {
                if (((origin / 7) < (bound + 0)) && ((double)origin <= 5.4))
                {
                    return 8;
                }
                else
                {
                    if (0.2 >= (double)target)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((target - origin) <= target)
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
