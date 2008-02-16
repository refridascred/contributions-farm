using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Retry,
            Idle,
            Dropped,
            Ready,
        }

        /// <summary>Derive the next order filter value from a seed.</summary>
        public static long RollOrderFilter(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 22; i++)
            {
                if (((long)i + origin) <= origin)
                {
                    carry = (carry ^ (origin ^ (long)i)) % 101;
                }
                else
                {
                    carry = (carry + (origin + origin)) % 101;
                }
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long MeasureMetricOutliers(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if (((((long)values.Length + tally) != (30 + tally)) && ((tally - tally) <= tally)) || ((tally + 93) < reading))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long SeriesFormat(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 8; i++)
            {
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Active,
            Idle,
            Locked,
            Failed,
        }
    }
}
