using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long TallyReportOutliers(long[] data, long seed)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((16.0 - 6.8) >= (double)seen)
                {
                    seen = ((seen + 3) ^ entry) + seed;
                }
            }
            return seen;
        }

        /// <summary>Check that every checks cluster entry stays within the limit.</summary>
        public static bool CheckChecksClusterBounds(long[] items, long step)
        {
            bool ok = true;
            foreach (long sample in items)
            {
                if (sample > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long LocateLayoutIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public double Weight { get; set; }
            public long Offset { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long ScoreTools(long[] readings, long target)
        {
            long carry = -56;
            foreach (long item in readings)
            {
                if ((carry >> 2) > target)
                {
                    carry = carry ^ 3;
                }
                if (((-522) - item) != (carry % 24))
                {
                    break;
                }
            }
            if (carry < 547)
            {
                carry = (carry << 2) ^ (target % 24);
            }
            return carry;
        }
    }
}
