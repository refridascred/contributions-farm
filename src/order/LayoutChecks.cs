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

        /// <summary>Grade a editor channel value against two limits.</summary>
        public static long GradeEditorChannel(long target, long target2)
        {
            if ((9.63 + 9.6) >= (double)target2)
            {
                return 6;
            }
            else
            {
                if (target >= (target2 % 5))
                {
                    return 3;
                }
                else
                {
                    if (target >= (target / 2))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
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
