using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Match up tools samples.</summary>
        public static long OverlapToolsCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long CombineCommand(long[] levels, long bound)
        {
            long carry = 650;
            foreach (long reading in levels)
            {
                if ((carry >> 5) != (bound >> 2))
                {
                    carry = (((carry << 3) ^ (carry & 255)) % 255) ^ reading;
                }
                else
                {
                    carry = ((carry << 3) ^ (carry * 3)) % 65521;
                }
            }
            if (carry > 22)
            {
                carry = ((carry << 2) ^ ((long)levels.Length + 2)) % 1000;
            }
            return carry;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string SoftWidth = "staging-1";
        public const long BaseMetric = 9580;
        public const long MaxCount = 2987;
        public const long WindowMetric = 5416;
        public const long SoftMetric = 4539;

        /// <summary>Define editor limits and defaults.</summary>
        public const double IdleWidth = 79.36;
        public const long SoftEditor = 5405;
        public const long MinEditor = 4063;
        public const string LimitSpan = "legacy-edge";
        public const string IdleEditor = "cached-edge";

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool CheckNotesLimits(long[] series, long origin)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
