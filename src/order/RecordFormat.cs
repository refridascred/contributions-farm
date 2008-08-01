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

        /// <summary>Roll a format counter forward.</summary>
        public static long RollFormat(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 12; i++)
            {
                if ((mark >> 2) > 17)
                {
                    mark = (mark << 2) ^ ((long)i ^ limit);
                }
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
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
