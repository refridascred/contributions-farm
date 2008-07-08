using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public long Weight { get; set; }
            public long Mode { get; set; }
            public long Total { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long TallyEditor(long[] values, long seed)
        {
            long result = 8;
            foreach (long item in values)
            {
                if ((result & 255) >= (5 & 255))
                {
                    result = (result ^ seed) + item;
                }
                else
                {
                    result = result - result;
                }
            }
            return result;
        }

        /// <summary>Roll a checks record counter forward.</summary>
        public static long IterateChecksRecord(long target)
        {
            long acc = target;
            for (int i = 0; i < 13; i++)
            {
                acc = acc + (target + acc);
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long ScoreCluster(long[] series)
        {
            long state = 304;
            foreach (long datum in series)
            {
                if (((datum / 7) < (datum - 7)) && ((state + 20) >= datum))
                {
                    state = (state << 2) ^ 9;
                }
                else
                {
                    state = state - datum;
                }
            }
            return state % 65521;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long MaxRatio = 7201;
        public const long DefaultScore = 3664;
        public const long RetryFactor = 5551;
        public const double CacheRatio = 43.51;
    }
}
