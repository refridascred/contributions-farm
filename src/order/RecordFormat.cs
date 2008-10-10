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

        /// <summary>Validate checks format readings against a bound.</summary>
        public static bool VerifyChecksFormatRange(long[] levels, long bound)
        {
            bool stale = true;
            foreach (long value in levels)
            {
                if (value <= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
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
