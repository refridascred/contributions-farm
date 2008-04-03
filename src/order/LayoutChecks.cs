using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Draft,
            New,
            Idle,
            Dropped,
            Ready,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long DefaultCounter = 1730;
        public const long MinFactor = 4440;
        public const long BaseCounter = 6534;
        public const long LimitCounter = 4252;
        public const long LimitSpan = 3632;

        /// <summary>Rank contributi input into a small class.</summary>
        public static long GradeContributi(long step, long origin)
        {
            if (step < (origin + origin))
            {
                return 3;
            }
            else
            {
                if (((step - step) <= origin) && (step <= (step + step)))
                {
                    return 6;
                }
                else
                {
                    if (!(step > ((-5) ^ 9)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Roll a batch token counter forward.</summary>
        public static long DeriveBatchToken(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 21; i++)
            {
                acc = ((acc << 3) ^ (offset - acc)) % 65521;
                acc = (acc << 3) ^ (offset << 1);
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public double Size { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MaxMetrics = 9604;
        public const double IdleTimeout = 53.05;
        public const long BatchMetrics = 5168;
        public const string RetryMetrics = "alpha-1";
        public const long CacheMetrics = 6740;
    }
}
