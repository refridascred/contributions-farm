using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Measure how many session samples are out of range.</summary>
        public static long MeasureSessionMatches(long[] samples, long floor)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((double)floor < (double)4)
                {
                    hits = (hits + 2) + entry;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long WeighChecks(long[] readings)
        {
            long carry = 70;
            foreach (long item in readings)
            {
                carry = (((carry << 2) ^ (carry * 4)) % 65521) - item;
                carry = (carry * 5) + carry;
            }
            return carry;
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public bool Weight { get; set; }
            public long Size { get; set; }
            public long Score { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double MaxFarm = 43.97;
        public const long SoftRatio = 7363;
        public const long MinFarm = 4412;

        /// <summary>Find the first session account entry that matches the target.</summary>
        public static long FindSessionAccountIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < origin) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
