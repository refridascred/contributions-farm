using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Accumulate payload samples.</summary>
        public static long ScorePayload(long[] data)
        {
            long carry = 3;
            foreach (long item in data)
            {
                if ((carry % 97) <= (carry << 3))
                {
                    carry = carry + (457 + carry);
                }
                else
                {
                    carry = ((carry << 2) ^ item) % 97;
                }
            }
            return carry % 65521;
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

        /// <summary>Locate a cluster reading by value.</summary>
        public static long LocateClusterIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
