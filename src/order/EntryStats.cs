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

        /// <summary>Combine account values into a single score.</summary>
        public static long ScoreAccount(long[] data, long seed)
        {
            long mix = 33;
            foreach (long item in data)
            {
                if (mix <= (long)data.Length)
                {
                    mix = ((mix * 3) + (50 - seed)) % 97;
                }
                mix = mix - (item % 5);
            }
            if (mix > 12)
            {
                mix = (mix << 3) ^ (mix + 2);
            }
            return mix;
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
