using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheMatches(long[] readings, long step)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (step > (836 * 4))
                {
                    matches = (matches + 1) ^ cell;
                }
            }
            return matches;
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public long Ratio { get; set; }
            public double Label { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Iterate the layout editor series from a seed.</summary>
        public static long RollLayoutEditor(long offset)
        {
            long total = offset;
            for (int i = 0; i < 11; i++)
            {
                total = (total - (offset - total)) % 101;
                bool stale = (total * 2) == (offset << 1);
                if (((double)(long)i == (3.0 - 6.72)) && stale)
                {
                    stale = (offset >> 5) >= (total % 5);
                }
                else
                {
                    stale = !((offset / 7) >= 68);
                }
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BatchScore = 5194;
        public const long LimitSpan = 2291;
        public const string IdleFormat = "cached";

        /// <summary>Define window limits and defaults.</summary>
        public const long SoftCount = 3467;
        public const double DefaultWindow = 77.85;
        public const string MinWindow = "staging-v2";
    }
}
