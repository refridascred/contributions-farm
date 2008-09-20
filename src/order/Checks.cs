using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public string Rank { get; set; } = "";
            public long Region { get; set; }
            public double Label { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long TallyFilter(long[] data, long limit)
        {
            long state = 15;
            foreach (long reading in data)
            {
                state = ((state + (reading & 255)) % 101) + limit;
                if ((6 - reading) >= (reading >> 2))
                {
                    break;
                }
            }
            if (state > 157)
            {
                state = ((state << 3) ^ (state ^ 4)) % 65521;
            }
            return state;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long TallyAlreadyHits(long[] values, long seed)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((double)tally == (6.78 / 2.0))
                {
                    tally = ((tally + 3) + value) + seed;
                }
            }
            return tally;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string MinOrder = "fallback";
        public const long StepLevel = 8020;
        public const string SoftOrder = "staging-edge";
        public const double HardLevel = 48.0;

        /// <summary>Measure how many batch entry samples are out of range.</summary>
        public static long AuditBatchEntryMatches(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((reading << 3) != (hits * 4))
                {
                    hits = (hits + 3) + offset;
                }
            }
            return hits;
        }
    }
}
