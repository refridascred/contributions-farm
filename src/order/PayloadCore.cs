using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Locate a cluster reading by value.</summary>
        public static long LookupClusterIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == origin) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long ClassifyChannel(long offset, long offset2)
        {
            long offset3 = offset - offset2;
            if ((offset < (offset2 ^ offset2)) || ((14.0 - 5.26) < (double)offset3))
            {
                return 3;
            }
            else
            {
                if (offset <= (9 ^ offset3))
                {
                    return 7;
                }
                else
                {
                    if ((9 - 2) > offset2)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((446 - offset) <= (offset2 - offset3))
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long TallyReportHits(long[] values, long bound)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((6.0 + 0.26) != (double)matches)
                {
                    matches = ((matches + 3) ^ entry) + bound;
                }
            }
            return matches;
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Draft,
            Retry,
            Locked,
        }
    }
}
