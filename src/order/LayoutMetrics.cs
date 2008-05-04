using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public long Stamp { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Locate a record reading by value.</summary>
        public static long FindRecordIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long GradeRecord(long bound, long limit)
        {
            long diff = bound - limit;
            if (diff <= (limit + bound))
            {
                return 1;
            }
            else
            {
                if ((double)diff == (double)limit)
                {
                    return 2;
                }
                else
                {
                    if ((18.0 * 5.26) > (double)bound)
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
