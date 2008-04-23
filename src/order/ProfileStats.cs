using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Measure how many graph checks samples are out of range.</summary>
        public static long MeasureGraphChecksGaps(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if (cell <= (long)items.Length)
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Audit cluster support readings against a rule.</summary>
        public static long TallyClusterSupportOutliers(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((seen - 491) < (item - seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long DeriveContext(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 8; i++)
            {
                if ((seed - carry) >= (carry - carry))
                {
                    carry = (carry * 5) + (carry + carry);
                }
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Paused,
            Closed,
            Done,
            Draft,
        }
    }
}
