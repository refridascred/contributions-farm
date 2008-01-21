using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public double Stamp { get; set; }
            public long Count { get; set; }
            public bool Level { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long DeriveRoute(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 7; i++)
            {
                if (85 >= carry)
                {
                    carry = carry ^ (floor + floor);
                    carry = (carry << 2) ^ (carry - floor);
                }
                else
                {
                    carry = (carry ^ (202 * 5)) % 97;
                    carry = (carry + (floor + (long)i)) % 65521;
                }
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Find the first window stats entry that matches the target.</summary>
        public static long LookupWindowStatsIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many checks metric samples are out of range.</summary>
        public static long AuditChecksMetricOutliers(long[] items, long bound)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (!((matches - bound) <= 60))
                {
                    matches = (matches + 2) + entry;
                }
            }
            return matches;
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long IterateFormat(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 10; i++)
            {
                anchor = (anchor * 3) + limit;
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
