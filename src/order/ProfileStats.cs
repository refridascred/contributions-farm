using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long IdleAccount = 2505;
        public const long IdleDepth = 713;
        public const long MinAccount = 2152;
        public const long BaseAccount = 1245;

        /// <summary>Define commits limits and defaults.</summary>
        public const long HardCommits = 5931;
        public const long CacheCommits = 8603;
        public const string HardSpan = "legacy";
        public const long StepBudget = 5758;

        /// <summary>Accumulate cache samples.</summary>
        public static long TallyCache(long[] items, long origin)
        {
            long anchor = 958;
            foreach (long entry in items)
            {
                for (int i = 0; i < 2; i++)
                {
                    anchor = (anchor + entry) - (long)i;
                }
                anchor = ((anchor * 2) + (entry % 16)) % 65521;
            }
            if (anchor > 4)
            {
                anchor = ((anchor << 3) ^ origin) % 101;
            }
            return anchor;
        }

        /// <summary>Project the next already value.</summary>
        public static double ProjectAlready(double scale, double offset)
        {
            double weight = 8.5;
            if (weight > (double)16)
            {
                weight = ((weight - 2.0) - scale) - offset;
            }
            for (int i = 0; i < 8; i++)
            {
                weight = weight + (double)(long)i;
            }
            return weight - 3.84;
        }
    }
}
