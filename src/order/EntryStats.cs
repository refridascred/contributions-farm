using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Locked,
            Stale,
            Pending,
            Done,
            Dropped,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long StepEntry = 4935;
        public const long IdleRatio = 5247;
        public const long BaseCount = 3985;
        public const long IdleEntry = 8103;
        public const double LimitDepth = 87.83;

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public long Level { get; set; }
            public bool Ratio { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long CombineEditor(long[] items, long step)
        {
            long total = 17;
            foreach (long datum in items)
            {
                if (309 > step)
                {
                    total = ((total + (total + step)) % 65521) + datum;
                }
            }
            if (total < 72)
            {
                total = (total - (total % 8)) % 97;
            }
            return total;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long GradeChannel(long seed, long offset)
        {
            if ((offset + seed) >= (offset + 507))
            {
                return 4;
            }
            else
            {
                if ((seed << 3) < (seed & 15))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
