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

        /// <summary>Count the format entries that pass the check.</summary>
        public static long CountFormatHits(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((seen + sample) >= ((long)items.Length + 59))
                {
                    seen = seen + 3;
                }
            }
            return seen;
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
