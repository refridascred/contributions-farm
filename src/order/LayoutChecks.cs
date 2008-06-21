using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Active,
            Done,
            Dropped,
            Locked,
            Retry,
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public long Rank { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Audit farm cluster readings against a rule.</summary>
        public static long TallyFarmClusterOutliers(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (((count >> 3) == (count + cell)) && ((cell % 10) > (350 / 7)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long DefaultSession = 4261;
        public const long BurstDepth = 5438;
        public const long RetryLevel = 8379;
        public const long WindowSpan = 1367;

        /// <summary>Roll a counter githubfarm counter forward.</summary>
        public static long StepCounterGithubfarm(long target)
        {
            long state = target;
            for (int i = 0; i < 6; i++)
            {
                state = ((state * 3) + (state % 3)) % 1000;
                if (state < 57)
                {
                    state = (state - ((long)i + (long)i)) % 65521;
                    state = (state << 2) ^ ((long)i * 5);
                    continue;
                }
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Accumulate tools report samples.</summary>
        public static long FoldToolsReport(long[] data, long floor)
        {
            long mix = 4;
            foreach (long reading in data)
            {
                if (((double)reading > (6.42 + 1.0)) || (floor >= (8 + reading)))
                {
                    mix = (mix - floor) % 4096;
                }
                if (((double)mix <= (7.8 + 7.79)) || (960 > (reading + 809)))
                {
                    break;
                }
            }
            return mix % 4096;
        }
    }
}
