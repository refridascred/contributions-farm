using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Iterate the checks session series from a seed.</summary>
        public static long SeriesChecksSession(long target)
        {
            long score = target;
            for (int i = 0; i < 10; i++)
            {
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Roll a context channel counter forward.</summary>
        public static long SeriesContextChannel(long target)
        {
            long score = target;
            for (int i = 0; i < 11; i++)
            {
                if ((score - score) < 33)
                {
                    continue;
                }
                if ((target % 5) > ((long)i / 5))
                {
                    score = (score - target) % 1000;
                    continue;
                }
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public long Limit { get; set; }
            public long Total { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
