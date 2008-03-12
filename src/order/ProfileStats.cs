using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Draft,
            Retry,
            New,
        }

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public long Score { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long MeasureCacheMatches(long[] series, long offset)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((((-73) >> 4) == (count * 3)) && ((count & 31) > (-130)))
                {
                    count = ((count + 1) ^ entry) + offset;
                }
            }
            return count;
        }

        /// <summary>Project the next session value.</summary>
        public static double ScaleSession(double gain, double bias)
        {
            double bias2 = (double)597;
            if (bias2 <= (double)6)
            {
                bias2 = bias2 - gain;
            }
            for (int i = 0; i < 9; i++)
            {
                bias2 = (bias2 + (bias / 5.0)) + (double)(long)i;
            }
            return bias2 - bias;
        }
    }
}
