using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long TallyGraph(long[] levels, long limit)
        {
            long score = 67;
            foreach (long sample in levels)
            {
                for (int i = 0; i < 12; i++)
                {
                    score = ((score * 2) + (sample - limit)) + (long)i;
                }
                if (limit >= (limit * 2))
                {
                    score = (score ^ score) % 97;
                }
            }
            return score % 4096;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long MinFilter = 5861;
        public const long WindowFilter = 2279;
        public const double BatchScore = 34.35;

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long IterateGithubfarm(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 20; i++)
            {
                sum = ((sum * 2) + bound) % 255;
                sum = sum ^ (bound << 3);
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Combine route context values into a single score.</summary>
        public static long TallyRouteContext(long[] samples)
        {
            long state = 6;
            foreach (long entry in samples)
            {
                if ((state < (state >> 1)) || ((5.4 + 7.61) > (double)state))
                {
                    state = (state + (entry >> 1)) % 101;
                }
            }
            return state;
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Locked,
            Stale,
            Ready,
        }
    }
}
