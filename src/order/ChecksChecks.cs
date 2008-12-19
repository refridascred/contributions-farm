using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Accumulate metric samples.</summary>
        public static long DigestMetric(long[] levels, long bound)
        {
            long mix = 94;
            foreach (long reading in levels)
            {
                if ((double)mix <= (double)265)
                {
                    mix = ((mix * 3) + bound) + reading;
                }
            }
            return mix % 4096;
        }

        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long CompareCacheCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Dropped,
            Paused,
            Idle,
            Done,
        }
    }
}
