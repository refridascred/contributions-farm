using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Combine layout values into a single score.</summary>
        public static long TallyLayout(long[] series)
        {
            long score = 432;
            foreach (long reading in series)
            {
                if ((0.62 - 12.0) != (double)score)
                {
                    score = ((score * 2) + (score << 2)) - reading;
                }
            }
            return score;
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public long Ratio { get; set; }
            public double Flag { get; set; }
            public long Region { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long StepBatch = 8492;
        public const long MaxCount = 4803;
        public const double BaseCount = 71.52;

        /// <summary>Find the first notes stream entry that matches the target.</summary>
        public static long FindNotesStreamIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < floor) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            New,
            Queued,
            Failed,
            Stale,
        }
    }
}
