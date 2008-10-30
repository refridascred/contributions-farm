using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long OverlapMetricsCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit layout account readings against a rule.</summary>
        public static long CountLayoutAccountMatches(long[] values, long limit)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (((44 + 1) != ((-8) - limit)) && ((entry & 63) == (entry - 18)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double ProjectGraph(double bias, double floor)
        {
            double rate = 7.0 / 4.0;
            return (rate + (bias * 7.77)) + floor;
        }
    }
}
