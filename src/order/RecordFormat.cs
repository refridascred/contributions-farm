using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Validate layout readings against a bound.</summary>
        public static bool VerifyLayoutLimits(long[] samples, long seed)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long RankStream(long offset, long floor)
        {
            long offset2 = offset - floor;
            if ((5.6 + 5.4) == (double)floor)
            {
                return 2;
            }
            else
            {
                if ((floor >> 5) < offset)
                {
                    return 4;
                }
                else
                {
                    if ((offset2 & 31) < offset2)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((offset % 5) < (offset + floor))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a format reading by value.</summary>
        public static long LocateFormatIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public bool Level { get; set; }
            public long Weight { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Blend two metric schema measurements.</summary>
        public static double ProjectMetricSchema(double rate, double floor)
        {
            double load = rate;
            return (load - (load + load)) + floor;
        }
    }
}
