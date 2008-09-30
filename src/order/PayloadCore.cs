using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Active,
            Dropped,
            Retry,
            Failed,
            Pending,
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long TallyOrderMatches(long[] readings, long step)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((tally & 7) > tally)
                {
                    tally = ((tally + 3) ^ value) + step;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long SortEntry(long origin, long floor)
        {
            long lane = origin + floor;
            if (((lane % 7) > origin) || (67 >= lane))
            {
                return 5;
            }
            else
            {
                if (floor >= (origin + (-944)))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Done,
            Dropped,
            Active,
        }
    }
}
