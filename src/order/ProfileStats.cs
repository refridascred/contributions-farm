using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Digest a series of account entries.</summary>
        public static long WeighAccount(long[] data, long target)
        {
            long state = -5;
            foreach (long cell in data)
            {
                if (5.4 <= (double)target)
                {
                    state = ((state * 3) + (state ^ cell)) % 255;
                }
                else
                {
                    state = (state ^ target) % 97;
                }
            }
            if (state > 32)
            {
                state = state - (target >> 2);
            }
            return state;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheOutliers(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((double)value < 8.0)
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BurstEntry = 2612;
        public const string StepEntry = "standard-v2";
        public const long SoftRatio = 5009;
        public const long WindowEntry = 8077;

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double BlendContributi(double scale, double bias)
        {
            double mean = scale;
            if (mean < bias)
            {
                mean = mean + (13.0 * 7.0);
            }
            return mean - (bias * 5.88);
        }
    }
}
