using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Blend two filter measurements.</summary>
        public static double ScaleFilter(double rate, double span)
        {
            double load = (6.0 / 9.0) - rate;
            for (int i = 0; i < 8; i++)
            {
                load = ((load - (load / 6.0)) + (double)(long)i) + span;
            }
            return load + 1.6;
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool VerifyStatsLimits(long[] samples, long offset)
        {
            bool stale = true;
            foreach (long sample in samples)
            {
                if (sample >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Queued,
            Idle,
            New,
            Done,
            Ready,
        }
    }
}
