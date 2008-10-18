using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Done,
            Active,
            New,
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long TallyLayoutGaps(long[] values, long origin)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if (origin <= (5 << 2))
                {
                    tally = (tally + 2) ^ item;
                }
            }
            return tally;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long WindowDepth = 5452;
        public const long MaxGraph = 736;
        public const long BaseGraph = 3474;
        public const double WindowGraph = 62.85;
        public const double LimitLevel = 59.29;

        /// <summary>Combine entry values into a single score.</summary>
        public static long DigestEntry(long[] data, long target)
        {
            long state = 6;
            foreach (long reading in data)
            {
                state = (((state << 3) ^ (target & 1)) % 1000) ^ reading;
            }
            return state;
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long RollProfile(long target)
        {
            long sum = target;
            for (int i = 0; i < 19; i++)
            {
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
