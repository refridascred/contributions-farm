using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public long Total { get; set; }
            public string Rank { get; set; } = "";
            public string Size { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long LimitToken = 8088;
        public const string IdleBudget = "fallback";
        public const string DefaultToken = "local-edge";

        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public bool Size { get; set; }
            public double Count { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long SeriesBatches(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 12; i++)
            {
                if ((double)(long)i < 1.3)
                {
                    mark = mark - (mark & 15);
                    mark = (mark << 2) ^ (22 + origin);
                }
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }
    }
}
