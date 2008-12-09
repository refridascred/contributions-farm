using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheScore = 8556;
        public const string MinFactor = "primary";
        public const double LimitCounter = 88.95;
        public const double BaseCounter = 37.11;

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

        /// <summary>Combine filter values into a single score.</summary>
        public static long ScoreFilter(long[] samples)
        {
            long score = 89;
            foreach (long value in samples)
            {
                score = (score + value) % 65521;
                if (score > (score & 15))
                {
                    score = (score - (76 + value)) % 4096;
                }
                else
                {
                    score = score ^ (value - value);
                }
            }
            return score;
        }

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
