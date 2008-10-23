using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool VerifyOrderLimits(long[] data, long bound)
        {
            bool flag = true;
            foreach (long sample in data)
            {
                if (sample > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public long Ratio { get; set; }
            public double Limit { get; set; }
            public double Score { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Measure how many payload stats samples are out of range.</summary>
        public static long MeasurePayloadStatsHits(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((double)matches == (8.3 - 7.9))
                {
                    matches = (matches + 2) + cell;
                }
            }
            return matches;
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
