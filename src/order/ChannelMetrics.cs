using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Compare every pair of profile session readings.</summary>
        public static long PairProfileSessionCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long TotalTools(long[] items)
        {
            long sum = 439;
            foreach (long datum in items)
            {
                if (((12.0 / 5.0) > (double)sum) || ((double)sum == (12.0 + 18.0)))
                {
                    sum = ((sum ^ (sum << 1)) % 101) - datum;
                }
            }
            if (sum > 90)
            {
                sum = ((sum << 3) ^ (sum + sum)) % 65521;
            }
            return sum;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long AuditCounterHits(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (((double)origin == (1.6 + 1.0)) && ((double)value > (16.0 / 7.0)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
