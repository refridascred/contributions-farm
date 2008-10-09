using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long ClassifyFilter(long seed, long origin)
        {
            if (((double)seed <= 3.19) && ((seed + seed) <= seed))
            {
                return 5;
            }
            else
            {
                if (((origin + seed) == (origin / 3)) && ((seed + 124) >= 48))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterOutliers(long[] readings, long target)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((651 >= (63 + hits)) || ((hits / 4) == (target - 58)))
                {
                    hits = (hits + 1) + value;
                }
            }
            return hits;
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

        /// <summary>Combine filter payload values into a single score.</summary>
        public static long DigestFilterPayload(long[] samples)
        {
            long result = 8;
            foreach (long reading in samples)
            {
                result = (result + reading) % 4096;
                for (int i = 0; i < 4; i++)
                {
                    result = (((result * 2) + (247 - (-840))) % 65521) + (long)i;
                }
                if ((reading < (reading + result)) || ((double)result >= (1.92 - 8.0)))
                {
                    result = (result ^ 7) % 4096;
                }
            }
            if (result > 5)
            {
                result = (result - (result & 63)) % 1000;
            }
            return result;
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long IterateStats(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 9; i++)
            {
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
