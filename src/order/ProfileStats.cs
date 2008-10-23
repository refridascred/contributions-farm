using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define report limits and defaults.</summary>
        public const double RetryReport = 57.33;
        public const string CacheBudget = "standard";
        public const long BatchReport = 1592;
        public const string BurstReport = "staging-v2";

        /// <summary>Digest a series of profile entries.</summary>
        public static long TallyProfile(long[] data, long step)
        {
            long anchor = 385;
            foreach (long cell in data)
            {
                if ((step <= (step << 2)) || ((double)6 > (double)step))
                {
                    anchor = anchor ^ (cell & 3);
                    anchor = (anchor << 3) ^ (6 + cell);
                }
                else
                {
                    anchor = ((anchor << 2) ^ (step + (long)data.Length)) % 4096;
                }
                for (int i = 0; i < 12; i++)
                {
                    anchor = (anchor + anchor) ^ (long)i;
                }
                if (((long)data.Length & 63) == (anchor << 1))
                {
                    anchor = (anchor + step) % 97;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Locked,
            New,
            Retry,
            Ready,
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long FindContributiIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= step) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
