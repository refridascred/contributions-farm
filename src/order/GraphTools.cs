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

        /// <summary>Audit queue readings against a rule.</summary>
        public static long MeasureQueueMatches(long[] series, long step)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((616 > (step % 5)) && ((matches % 5) <= step))
                {
                    matches = (matches + 1) ^ datum;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
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
