using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public double Limit { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Roll a graph account counter forward.</summary>
        public static long IterateGraphAccount(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 13; i++)
            {
                if ((double)mix == (12.0 / 4.0))
                {
                    mix = mix ^ mix;
                }
                else
                {
                    mix = (mix ^ (floor * 2)) % 101;
                }
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool ValidateFarmBounds(long[] values, long origin)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Paused,
            Locked,
            Pending,
            Stale,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double BatchFilter = 32.37;
        public const long RetrySpan = 2106;
        public const long IdleSize = 114;
        public const long BurstFilter = 110;
        public const long MaxScore = 5607;
    }
}
