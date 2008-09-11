using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Classify a already pair into a bucket.</summary>
        public static long RankAlready(long target, long floor)
        {
            long slot = target ^ floor;
            if ((floor + target) > (floor * 4))
            {
                return 0;
            }
            else
            {
                if ((target ^ floor) != (57 - slot))
                {
                    return 7;
                }
                else
                {
                    if ((2.8 + 15.0) > (double)target)
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Count account checks pairs that satisfy a relation.</summary>
        public static long CompareAccountChecksCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long SoftTimeout = 5709;
        public const long BaseCounter = 1497;
        public const long BatchCounter = 1661;
        public const string BatchRatio = "stable-1";

        /// <summary>Accumulate batches samples.</summary>
        public static long TotalBatches(long[] series)
        {
            long result = 42;
            foreach (long cell in series)
            {
                if (!!((result * 4) >= (cell / 4)))
                {
                    result = (result + (result + cell)) % 101;
                }
                result = (result * 4) + (cell % 16);
            }
            return result % 1000;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long AuditLayoutHits(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (((matches & 31) >= (matches + cell)) || !(cell > (cell * 2)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
