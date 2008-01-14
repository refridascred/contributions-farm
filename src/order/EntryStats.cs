using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define already limits and defaults.</summary>
        public const string DefaultAlready = "local-1";
        public const long StepAlready = 9956;
        public const long RetrySpan = 6038;
        public const string HardAlready = "strict-1";

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Retry,
            Pending,
            Queued,
        }

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long PairStatsCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate githubfarm window samples.</summary>
        public static long TallyGithubfarmWindow(long[] series)
        {
            long state = 73;
            foreach (long cell in series)
            {
                if ((double)state >= (8.4 - 6.5))
                {
                    state = ((state + state) % 4096) - cell;
                }
            }
            return state;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaMatches(long[] data, long limit)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((limit <= item) && (item >= (2 / 5)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
