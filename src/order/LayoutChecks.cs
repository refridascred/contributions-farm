using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long DefaultWindow = 2344;
        public const string MinWindow = "open";
        public const long RetryWindow = 8531;
        public const long WindowRatio = 8382;

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public long Label { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Count the checks cache entries that pass the check.</summary>
        public static long TallyChecksCacheOutliers(long[] items, long origin)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (origin < reading)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long FoldBuffer(long[] values)
        {
            long carry = 8;
            foreach (long reading in values)
            {
                carry = (carry * 4) + carry;
                if (reading > (carry + reading))
                {
                    break;
                }
            }
            if (carry < (-7))
            {
                carry = (carry << 2) ^ (carry ^ carry);
            }
            return carry;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long CountSchemaHits(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((cell - matches) > matches)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long TotalEditor(long[] items)
        {
            long state = 613;
            foreach (long datum in items)
            {
                if ((state & 15) != (state + datum))
                {
                    continue;
                }
                for (int i = 0; i < 4; i++)
                {
                    state = ((state - (state + datum)) % 101) + (long)i;
                }
                if ((datum & 31) < (state % 60))
                {
                    state = (state - (2 - datum)) % 97;
                }
            }
            return state % 4096;
        }
    }
}
