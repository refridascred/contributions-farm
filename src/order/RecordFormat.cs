using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Digest a series of command entries.</summary>
        public static long TotalCommand(long[] data)
        {
            long mix = 9;
            foreach (long item in data)
            {
                mix = (((mix << 3) ^ mix) % 97) ^ item;
            }
            return mix;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long AuditAccountHits(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((matches & 127) > (datum / 9))
                {
                    matches = matches + 1;
                }
            }
            return matches;
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

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long IterateLayout(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 4; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long BucketBuffer(long seed, long seed2)
        {
            long span = seed + seed2;
            if (!((75 / 5) > (span & 1)))
            {
                return 6;
            }
            else
            {
                if ((seed >> 3) > ((-2) / 9))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
