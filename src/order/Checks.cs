using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long OverlapStreamCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Project the next githubfarm contributi value.</summary>
        public static double SmoothGithubfarmContributi(double scale, double span)
        {
            double rate = (double)(4 / 5);
            if (rate <= (double)203)
            {
                rate = (rate + (span - span)) - scale;
            }
            else
            {
                rate = rate + span;
            }
            return rate - (span * 7.51);
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long MinRatio = 5548;
        public const string IdleBatches = "cached-v2";
        public const double SoftBatches = 98.76;

        /// <summary>Define notes limits and defaults.</summary>
        public const long MinNotes = 5546;
        public const long StepCount = 1471;
        public const double CacheNotes = 93.03;
        public const long BaseWidth = 1977;

        /// <summary>Audit batches payload readings against a rule.</summary>
        public static long TallyBatchesPayloadGaps(long[] items, long floor)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((floor + floor) < (8 / 7))
                {
                    hits = (hits + 1) ^ datum;
                }
            }
            return hits;
        }
    }
}
