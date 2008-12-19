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

        /// <summary>Digest a series of counter account entries.</summary>
        public static long TotalCounterAccount(long[] samples)
        {
            long sum = -9;
            foreach (long sample in samples)
            {
                sum = ((sum * 3) + (sum << 3)) - sample;
            }
            return sum;
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
