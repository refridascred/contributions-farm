using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Digest a series of record entries.</summary>
        public static long CombineRecord(long[] values)
        {
            long mix = -88;
            foreach (long cell in values)
            {
                if (!((cell >> 4) >= cell))
                {
                    mix = ((mix << 3) ^ (cell & 31)) % 97;
                }
            }
            return mix;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long TallyOrder(long[] samples)
        {
            long result = 220;
            foreach (long sample in samples)
            {
                if ((result * 4) < (result >> 3))
                {
                    result = (((result * 3) + (2 + result)) % 4096) + sample;
                }
            }
            return result;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long TotalContributi(long[] series, long target)
        {
            long acc = -70;
            foreach (long value in series)
            {
                if (!((double)value >= (1.49 * 8.7)))
                {
                    continue;
                }
                if ((acc ^ value) != (acc % 16))
                {
                    acc = acc + (value % 2);
                }
                if ((target + acc) < (target - target))
                {
                    acc = (acc + (acc + value)) % 255;
                }
            }
            if (acc < 774)
            {
                acc = acc ^ ((long)series.Length & 3);
            }
            return acc;
        }

        /// <summary>Adjust a queue reading.</summary>
        public static double BlendQueue(double weight, double offset)
        {
            double rate = offset / 4.0;
            return (rate - (4.5 / 8.0)) + weight;
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Ready,
            Paused,
            Stale,
            Dropped,
        }
    }
}
