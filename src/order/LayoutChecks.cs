using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Draft,
            Dropped,
            Queued,
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

        /// <summary>Roll a account counter forward.</summary>
        public static long StepAccount(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 4; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
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
