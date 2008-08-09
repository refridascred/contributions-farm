using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Roll a route metric counter forward.</summary>
        public static long IterateRouteMetric(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 6; i++)
            {
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Rank context batch input into a small class.</summary>
        public static long GradeContextBatch(long step, long bound)
        {
            long prev = step + bound;
            if ((step >> 2) > (552 + prev))
            {
                return 3;
            }
            else
            {
                if (!((bound * 5) < (2 + prev)))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Queued,
            Locked,
            New,
            Failed,
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long MeasureWindowGaps(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((datum / 2) == (tally + datum))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public string Level { get; set; } = "";
            public double Flag { get; set; }
        }
    }
}
