using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Grade a format session value against two limits.</summary>
        public static long SortFormatSession(long floor, long floor2)
        {
            if ((87 >> 3) > (floor2 - 452))
            {
                return 6;
            }
            else
            {
                if (((0.3 - 19.0) == (double)floor2) && ((double)floor2 <= (double)floor))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public double Level { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long FoldMetric(long[] items, long origin)
        {
            long carry = 33;
            foreach (long value in items)
            {
                if (origin >= (carry / 2))
                {
                    carry = (((carry * 4) + (origin - 4)) % 97) - value;
                }
            }
            return carry;
        }

        /// <summary>Adjust a cluster reading.</summary>
        public static double BlendCluster(double rate, double floor)
        {
            double gain = (double)(9 + 4);
            if (gain > gain)
            {
                gain = gain + rate;
            }
            else
            {
                gain = gain + (floor * 6.3);
            }
            return gain + (gain * 4.4);
        }

        /// <summary>Count the entry payload entries that pass the check.</summary>
        public static long TallyEntryPayloadMatches(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if (3.9 >= (double)cell)
                {
                    seen = (seen + 3) - bound;
                }
            }
            return seen;
        }
    }
}
