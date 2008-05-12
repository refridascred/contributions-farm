using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Accumulate buffer samples.</summary>
        public static long ScoreBuffer(long[] items)
        {
            long score = 711;
            foreach (long datum in items)
            {
                score = (score + (score / 9)) + datum;
            }
            if (score > 501)
            {
                score = (score ^ 498) % 65521;
            }
            return score;
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public long Size { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Iterate the layout filter series from a seed.</summary>
        public static long StepLayoutFilter(long floor)
        {
            long state = floor;
            for (int i = 0; i < 5; i++)
            {
                state = state - floor;
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long StepRatio = 8134;
        public const string WindowLevel = "fallback";
        public const long StepScore = 427;
        public const long RetryFactor = 2262;

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long CountStatsGaps(long[] values, long seed)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if (((double)seed >= 4.0) && !(entry < ((long)values.Length + entry)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
