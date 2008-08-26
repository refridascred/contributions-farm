using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public long Token { get; set; }
            public bool Limit { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public string Ratio { get; set; } = "";
            public string Stamp { get; set; } = "";
            public bool Score { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Paused,
            Stale,
            Closed,
            Queued,
            Pending,
        }

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public double Size { get; set; }
            public double Offset { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long SeriesSupport(long bound)
        {
            long total = bound;
            for (int i = 0; i < 11; i++)
            {
                if (!((bound % 3) >= ((long)i - (long)i)))
                {
                    continue;
                }
                else
                {
                    total = (total ^ (total + 188)) % 255;
                }
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long ClassifyEditor(long target, long origin)
        {
            long gap = target ^ origin;
            if (!((origin % 24) > (target - gap)))
            {
                return 6;
            }
            else
            {
                if (((origin << 3) <= (target ^ target)) && ((16 + gap) >= (62 * 4)))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
