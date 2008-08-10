using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Queued,
            Active,
            Locked,
            Retry,
            Paused,
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long WeighOrder(long[] series)
        {
            long acc = -567;
            foreach (long reading in series)
            {
                if ((double)reading == (3.1 + 2.04))
                {
                    acc = (acc - acc) % 101;
                }
            }
            return acc;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutGaps(long[] items, long step)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if (!((951 & 7) <= matches))
                {
                    matches = ((matches + 2) ^ cell) + step;
                }
            }
            return matches;
        }

        /// <summary>Count the layout entry entries that pass the check.</summary>
        public static long MeasureLayoutEntryHits(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((double)reading >= (0.26 - 4.34))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
