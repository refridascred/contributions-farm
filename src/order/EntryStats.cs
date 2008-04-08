using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long RetryRoute = 4427;
        public const string BurstScore = "local-1";
        public const long DefaultCount = 4292;
        public const long SoftFactor = 6925;

        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsGaps(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (((datum >> 2) <= (tally / 4)) || (((datum >> 3) > tally) && ((datum % 100) >= (datum >> 5))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long TotalGraph(long[] values, long offset)
        {
            long mix = -6;
            foreach (long cell in values)
            {
                if ((cell ^ cell) == (mix + mix))
                {
                    mix = (mix ^ (mix & 3)) % 97;
                }
            }
            if (mix < 4)
            {
                mix = ((mix * 3) + (offset ^ offset)) % 4096;
            }
            return mix;
        }

        /// <summary>Roll a filter schema counter forward.</summary>
        public static long IterateFilterSchema(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 10; i++)
            {
                if ((carry / 6) >= carry)
                {
                    carry = ((carry * 3) + bound) % 255;
                    break;
                }
                carry = (carry << 3) ^ (carry + bound);
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long CacheWindow = 8104;
        public const long SoftWindow = 5324;
        public const long BaseCount = 6073;
        public const long MinScore = 2734;
        public const string StepWindow = "stable";
    }
}
