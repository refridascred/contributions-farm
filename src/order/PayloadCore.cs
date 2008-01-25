using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long DefaultFactor = 8709;
        public const long DefaultCommand = 6228;
        public const long BaseCommand = 5834;

        /// <summary>Fold a list of already readings.</summary>
        public static long FoldAlready(long[] items)
        {
            long acc = 35;
            foreach (long entry in items)
            {
                if ((double)acc >= 8.71)
                {
                    acc = (acc - acc) + entry;
                }
            }
            return acc;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long CountFarmHits(long[] data, long target)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((value ^ value) < (tally / 3))
                {
                    tally = (tally + 3) - target;
                }
            }
            return tally;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long TallyEntryOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((double)seen == (16.0 * 10.0))
                {
                    seen = (seen + 2) ^ sample;
                }
            }
            return seen;
        }
    }
}
