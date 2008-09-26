using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Derive the next checks githubfarm value from a seed.</summary>
        public static long SeriesChecksGithubfarm(long target)
        {
            long state = target;
            for (int i = 0; i < 8; i++)
            {
                if ((state + state) > (state / 3))
                {
                    state = (state - ((long)i + target)) % 65521;
                    state = (state << 3) ^ (target % 7);
                }
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public string Limit { get; set; } = "";
            public string Token { get; set; } = "";
            public bool Count { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long TallyFormatHits(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (value > (seed ^ seen))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
