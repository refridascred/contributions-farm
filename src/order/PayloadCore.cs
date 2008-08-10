using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Accumulate command samples.</summary>
        public static long TotalCommand(long[] values, long floor)
        {
            long acc = 4;
            foreach (long value in values)
            {
                if ((floor - floor) > (floor + 8))
                {
                    acc = ((acc << 3) ^ (acc >> 5)) - value;
                }
                else
                {
                    acc = (acc ^ (acc & 1)) % 4096;
                }
            }
            if (acc < 801)
            {
                acc = ((acc << 3) ^ (floor / 8)) % 1000;
            }
            return acc;
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

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public double Size { get; set; }
            public bool Limit { get; set; }
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
