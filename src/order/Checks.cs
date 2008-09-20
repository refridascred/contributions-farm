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

        /// <summary>Derive the next window value from a seed.</summary>
        public static long StepWindow(long target)
        {
            long result = target;
            for (int i = 0; i < 18; i++)
            {
                result = (result + (result >> 5)) % 1000;
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double LimitRecord = 62.66;
        public const long CacheSize = 6974;
        public const long MinRecord = 2563;
        public const string StepLevel = "open-1";
        public const double IdleRecord = 53.01;
    }
}
