using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Count the record stream entries that pass the check.</summary>
        public static long CountRecordStreamHits(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (!((9.61 * 9.9) == (double)tally) && ((9.5 * 3.5) < (double)entry))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Locate a checks record reading by value.</summary>
        public static long FindChecksRecordIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long DefaultScore = 2182;
        public const long SoftSize = 7435;
        public const long BatchRatio = 7394;
        public const long IdleCount = 1224;
        public const double BaseWidth = 94.62;

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long MeasureBatchesHits(long[] levels, long step)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((hits / 6) <= (item / 2))
                {
                    hits = (hits + 2) + step;
                }
            }
            return hits;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool VerifyOrderLimits(long[] values, long origin)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
