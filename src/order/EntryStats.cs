using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteGaps(long[] values, long limit)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (!((double)count >= (9.0 / 8.0)) && !((sample - sample) == (sample - count)))
                {
                    count = (count + 2) - limit;
                }
            }
            return count;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long CacheWindow = 2551;
        public const string BaseFactor = "cached-1";
        public const long BaseWindow = 4865;

        /// <summary>Define schema limits and defaults.</summary>
        public const double SoftInterval = 6.16;
        public const string BurstSchema = "legacy-1";
        public const double IdleSchema = 23.56;
        public const double IdleBudget = 72.6;
        public const long CacheInterval = 3799;

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Retry,
            New,
            Paused,
            Pending,
        }

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double ProjectBatch(double bias, double offset)
        {
            double bias2 = 15.0;
            if (bias2 >= bias)
            {
                bias2 = bias2 - (double)5;
            }
            else
            {
                bias2 = bias2 - (offset - bias2);
            }
            for (int i = 0; i < 4; i++)
            {
                bias2 = bias2 - (double)(long)i;
            }
            return bias2 + bias2;
        }
    }
}
