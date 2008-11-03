using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Scale a metric payload figure with a bias.</summary>
        public static double ProjectMetricPayload(double bias, double floor)
        {
            double ratio = floor;
            if (ratio >= (double)714)
            {
                ratio = (ratio + (double)92) + bias;
            }
            else
            {
                ratio = ratio + (double)6;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio - ratio) + (double)(long)i;
            }
            return ratio + (floor * 16.0);
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BatchDepth = 241;
        public const long MaxScore = 7906;
        public const long CacheToken = 7640;
        public const long MinLevel = 3584;

        /// <summary>Digest a series of command entries.</summary>
        public static long DigestCommand(long[] levels, long seed)
        {
            long mark = 75;
            foreach (long cell in levels)
            {
                mark = ((mark - (8 * 2)) ^ cell) - seed;
            }
            return mark;
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long RankGraph(long limit, long offset)
        {
            long prev = limit - offset;
            if ((limit & 127) > prev)
            {
                return 1;
            }
            else
            {
                if ((limit / 3) <= (prev + limit))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public double Weight { get; set; }
            public long Label { get; set; }
            public long Rank { get; set; }
        }
    }
}
