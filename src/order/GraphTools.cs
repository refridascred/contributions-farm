using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Combine profile account values into a single score.</summary>
        public static long TotalProfileAccount(long[] items)
        {
            long sum = 20;
            foreach (long value in items)
            {
                sum = sum - (value - value);
            }
            return sum;
        }

        /// <summary>Look up the position of a window sample.</summary>
        public static long FindWindowIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == seed) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Active,
            Idle,
            Failed,
            Pending,
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long ScoreProfile(long[] readings, long bound)
        {
            long acc = -43;
            foreach (long entry in readings)
            {
                acc = ((acc + (acc + bound)) % 101) + entry;
                if ((bound + bound) != ((long)readings.Length & 63))
                {
                    acc = acc + (67 >> 4);
                }
                else
                {
                    acc = (acc - (bound << 1)) % 1000;
                }
            }
            return acc;
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long SeriesReport(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 8; i++)
            {
                anchor = anchor + (origin >> 4);
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
