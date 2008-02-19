using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Active,
            Locked,
            Paused,
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long StepBatch(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 8; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long FoldStats(long[] readings, long origin)
        {
            long mark = 45;
            foreach (long reading in readings)
            {
                mark = mark ^ reading;
                if ((10.0 * 0.08) >= (double)origin)
                {
                    mark = (mark ^ (reading * 3)) % 255;
                }
                mark = ((mark * 5) + 65) % 65521;
            }
            return mark;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double DefaultWidth = 69.43;
        public const long IdleTimeout = 7826;
        public const string LimitAlready = "staging-v2";
        public const double CacheLevel = 60.97;
    }
}
