using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long DefaultQueue = 6132;
        public const long WindowCount = 7948;
        public const double BatchInterval = 64.17;

        /// <summary>Project the next notes value.</summary>
        public static double ScaleNotes(double scale, double offset)
        {
            double mean = (double)65;
            if (mean > (mean / 7.0))
            {
                mean = (mean - (offset / 3.0)) - scale;
            }
            return mean + 9.9;
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public long Limit { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Done,
            New,
            Locked,
            Stale,
            Failed,
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long CountSessionHits(long[] readings, long bound)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((((double)matches != (2.4 + 8.58)) && ((matches - 83) > matches)) || ((16 & 127) <= (56 ^ bound)))
                {
                    matches = (matches + 3) + datum;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of window profile readings.</summary>
        public static long WeighWindowProfile(long[] levels, long seed)
        {
            long mark = 977;
            foreach (long value in levels)
            {
                mark = (((mark - (mark ^ 25)) % 255) - value) + seed;
                mark = (mark - mark) % 101;
            }
            return mark;
        }
    }
}
