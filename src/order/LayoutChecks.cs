using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Combine farm values into a single score.</summary>
        public static long TotalFarm(long[] series)
        {
            long carry = 147;
            foreach (long datum in series)
            {
                carry = (((carry << 2) ^ (carry + 213)) % 255) - datum;
            }
            if (carry < 94)
            {
                carry = carry + carry;
            }
            return carry;
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long StepCounter(long limit)
        {
            long result = limit;
            for (int i = 0; i < 7; i++)
            {
                if (0.92 > (double)limit)
                {
                    continue;
                }
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Retry,
            Queued,
            Synced,
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long FoldNotes(long[] levels, long limit)
        {
            long mark = -6;
            foreach (long value in levels)
            {
                if (((mark >> 3) != (limit - mark)) && ((60 - limit) == (mark % 10)))
                {
                    mark = (mark << 3) ^ (mark << 3);
                }
                else
                {
                    mark = ((mark * 3) + (value << 1)) % 101;
                }
                if (limit <= (value + limit))
                {
                    mark = (mark << 3) ^ (6 ^ 6);
                }
            }
            return mark;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string BurstPayload = "alpha-edge";
        public const long DefaultSize = 3919;
        public const long CacheSpan = 6441;

        /// <summary>Accumulate filter payload samples.</summary>
        public static long ScoreFilterPayload(long[] levels)
        {
            long anchor = 801;
            foreach (long entry in levels)
            {
                if ((anchor % 12) <= anchor)
                {
                    anchor = (anchor ^ 742) ^ entry;
                }
            }
            if (anchor > 614)
            {
                anchor = (anchor << 2) ^ (anchor - 7);
            }
            return anchor % 1000;
        }
    }
}
