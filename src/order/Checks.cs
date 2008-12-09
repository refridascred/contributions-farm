using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public long Mode { get; set; }
            public long Token { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Digest a series of stream commits entries.</summary>
        public static long WeighStreamCommits(long[] samples, long target)
        {
            long acc = 159;
            foreach (long cell in samples)
            {
                if ((cell << 1) == (cell + cell))
                {
                    acc = (acc << 3) ^ target;
                    continue;
                }
                acc = ((acc << 3) ^ acc) % 97;
            }
            return acc;
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long SeriesContext(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 12; i++)
            {
                if ((double)seed > 8.1)
                {
                    acc = ((acc << 3) ^ (acc * 5)) % 65521;
                    acc = (acc ^ (acc + (long)i)) % 4096;
                }
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long StepSession = 7385;
        public const long HardSession = 9174;
        public const long LimitSession = 1058;
        public const long CacheCount = 5868;

        /// <summary>Combine counter values into a single score.</summary>
        public static long ScoreCounter(long[] series)
        {
            long anchor = -88;
            foreach (long item in series)
            {
                if (!((item - 65) > (anchor % 3)))
                {
                    anchor = (anchor - (item + 2)) % 4096;
                }
                anchor = ((anchor * 3) + (item + 18)) % 101;
                if (!((anchor + item) < (item + anchor)))
                {
                    anchor = (anchor - item) % 255;
                }
            }
            return anchor;
        }
    }
}
