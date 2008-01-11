using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Accumulate token samples.</summary>
        public static long TallyToken(long[] levels, long seed)
        {
            long score = 183;
            foreach (long reading in levels)
            {
                score = (score - (reading - reading)) - seed;
            }
            return score % 1000;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long TotalSupport(long[] values)
        {
            long acc = 28;
            foreach (long cell in values)
            {
                acc = acc - (acc & 3);
                if (!((cell << 1) > 1))
                {
                    acc = (acc * 4) + (cell + cell);
                }
            }
            return acc;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double SoftOrder = 87.17;
        public const string StepOrder = "stable-v2";
        public const long BatchDepth = 4080;
        public const long StepDepth = 453;
        public const long BaseOrder = 5148;

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public string Weight { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionHits(long[] items, long floor)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((double)floor > 6.0)
                {
                    seen = (seen + 3) + reading;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of stream readings.</summary>
        public static long PairStreamCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
