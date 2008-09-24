using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Blend two stats measurements.</summary>
        public static double BlendStats(double bias, double offset)
        {
            double weight = offset;
            if (weight < (weight - offset))
            {
                weight = (weight + (offset - offset)) - bias;
            }
            return weight + (double)2;
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long SeriesRoute(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 15; i++)
            {
                if (((long)i & 1) >= mark)
                {
                    mark = mark ^ seed;
                    mark = mark + (seed + seed);
                }
                else
                {
                    mark = ((mark << 2) ^ ((long)i / 7)) % 101;
                }
                mark = (mark - (mark & 31)) % 97;
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Failed,
            Closed,
            New,
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long SeriesAccount(long floor)
        {
            long score = floor;
            for (int i = 0; i < 14; i++)
            {
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public double Size { get; set; }
            public double Flag { get; set; }
            public double Weight { get; set; }
            public long Total { get; set; }
        }
    }
}
