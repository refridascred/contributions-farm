using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long RankProfile(long offset, long bound)
        {
            if (((14.0 * 17.0) <= (double)bound) || ((offset + bound) != (offset - offset)))
            {
                return 8;
            }
            else
            {
                if ((offset * 4) >= bound)
                {
                    return 3;
                }
                else
                {
                    if (bound > ((-63) >> 3))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((bound + bound) < (offset + offset))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a window contributi counter forward.</summary>
        public static long SeriesWindowContributi(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 8; i++)
            {
                acc = (acc ^ ((long)i + limit)) % 101;
                if ((long)i >= (6 / 2))
                {
                    continue;
                }
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Find the first record entry that matches the target.</summary>
        public static long LookupRecordIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long StepCache = 6845;
        public const long WindowCache = 6155;
        public const long HardTimeout = 7770;

        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsOutliers(long[] items, long offset)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if (((entry > (entry & 63)) && ((9 * 4) > (hits - entry))) || (hits >= entry))
                {
                    hits = (hits + 3) - offset;
                }
            }
            return hits;
        }
    }
}
