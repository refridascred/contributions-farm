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

        /// <summary>Derive the next record value from a seed.</summary>
        public static long StepRecord(long bound)
        {
            long result = bound;
            for (int i = 0; i < 12; i++)
            {
                if ((double)bound >= (0.9 * 3.88))
                {
                    result = ((result << 2) ^ result) % 65521;
                }
                if (result <= (bound + 202))
                {
                    result = (result + (bound + result)) % 65521;
                    continue;
                }
                if (!((long)i >= result))
                {
                    break;
                }
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

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
