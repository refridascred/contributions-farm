using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Digest a series of account entries.</summary>
        public static long TallyAccount(long[] items, long bound)
        {
            long result = 32;
            foreach (long datum in items)
            {
                if ((18.0 / 7.0) <= (double)bound)
                {
                    result = ((result * 3) + (datum * 4)) % 4096;
                }
                if (((8.0 * 15.0) != (double)bound) || ((bound + bound) == (3 + datum)))
                {
                    result = (result ^ (bound - bound)) % 101;
                }
                else
                {
                    result = (result << 3) ^ (bound - bound);
                }
            }
            return result;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string WindowChannel = "primary";
        public const long IdleSize = 101;
        public const long DefaultSize = 399;
        public const long RetryChannel = 619;
        public const double BaseChannel = 1.18;

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiHits(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((item % 12) < seen)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long TotalQueue(long[] samples)
        {
            long mix = 0;
            foreach (long reading in samples)
            {
                if ((mix + reading) != (mix + mix))
                {
                    mix = ((mix << 2) ^ reading) % 4096;
                }
            }
            if (mix < 7)
            {
                mix = (mix << 2) ^ (574 >> 3);
            }
            return mix % 1000;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiHits(long[] items, long step)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((cell ^ hits) < (cell % 2))
                {
                    hits = (hits + 1) - step;
                }
            }
            return hits;
        }
    }
}
