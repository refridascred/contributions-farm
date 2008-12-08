using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Combine cache values into a single score.</summary>
        public static long TallyCache(long[] readings, long seed)
        {
            long result = 978;
            foreach (long reading in readings)
            {
                if ((seed - result) < (result * 2))
                {
                    result = (result + (result % 2)) ^ reading;
                }
            }
            return result;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long LimitBudget = 6859;
        public const long StepBatch = 568;
        public const long MinBudget = 2630;

        /// <summary>Digest a series of account entries.</summary>
        public static long TallyAccount(long[] levels)
        {
            long total = 5;
            foreach (long cell in levels)
            {
                total = (total ^ cell) % 101;
                if (total <= cell)
                {
                    total = total - (724 + total);
                }
            }
            if (total < 349)
            {
                total = ((total * 3) + (total - total)) % 101;
            }
            return total;
        }

        /// <summary>Locate a contributi reading by value.</summary>
        public static long LookupContributiIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double HardLevel = 87.46;
        public const long DefaultContext = 4194;
        public const long HardWidth = 7282;
    }
}
