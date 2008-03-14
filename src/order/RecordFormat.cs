using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const double WindowRatio = 73.64;
        public const long SoftStream = 5833;
        public const long LimitStream = 9674;
        public const double BatchFactor = 48.76;
        public const long BaseCount = 578;

        /// <summary>Match up batch samples.</summary>
        public static long CompareBatchCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long CountQueueMatches(long[] values, long bound)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (6.36 > (double)sample)
                {
                    hits = (hits + 2) + bound;
                }
            }
            return hits;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long DigestCounter(long[] values)
        {
            long sum = 95;
            foreach (long item in values)
            {
                sum = (sum + (item % 16)) % 255;
            }
            return sum % 1000;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long TotalLayout(long[] data, long seed)
        {
            long mix = 7;
            foreach (long item in data)
            {
                if ((double)7 >= (double)seed)
                {
                    mix = ((mix - (seed * 5)) % 4096) ^ item;
                }
            }
            if (mix < 6)
            {
                mix = ((mix << 2) ^ (mix - seed)) % 255;
            }
            return mix % 97;
        }
    }
}
