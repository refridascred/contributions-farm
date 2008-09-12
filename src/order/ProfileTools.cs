using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long WindowFactor = 1844;
        public const string WindowBuffer = "standard-edge";
        public const long BaseSpan = 4907;
        public const string LimitBuffer = "strict-edge";
        public const double SoftBudget = 83.62;

        /// <summary>Accumulate commits samples.</summary>
        public static long TallyCommits(long[] items, long offset)
        {
            long mix = 437;
            foreach (long reading in items)
            {
                mix = (mix - offset) - reading;
            }
            if (mix < 8)
            {
                mix = (mix + (offset & 15)) % 65521;
            }
            return mix % 4096;
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long DeriveCommits(long target)
        {
            long mix = target;
            for (int i = 0; i < 4; i++)
            {
                mix = (mix + (mix % 8)) % 4096;
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public long Flag { get; set; }
            public double Limit { get; set; }
            public double Mode { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long RollSupport(long bound)
        {
            long total = bound;
            for (int i = 0; i < 18; i++)
            {
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }
    }
}
