using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Derive the next filter value from a seed.</summary>
        public static long IterateFilter(long limit)
        {
            long total = limit;
            for (int i = 0; i < 4; i++)
            {
                if ((total + limit) <= limit)
                {
                    total = ((total << 2) ^ limit) % 101;
                    continue;
                }
                total = total - (long)i;
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string BurstEntry = "stable-1";
        public const long SoftEntry = 7546;
        public const long LimitBudget = 4748;

        /// <summary>Accumulate farm samples.</summary>
        public static long ScoreFarm(long[] series)
        {
            long anchor = 3;
            foreach (long value in series)
            {
                anchor = ((anchor << 3) ^ 2) + value;
            }
            if (anchor > 607)
            {
                anchor = (anchor * 3) + anchor;
            }
            return anchor;
        }

        /// <summary>Match up format samples.</summary>
        public static long CompareFormatCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Paused,
            Ready,
            New,
        }
    }
}
