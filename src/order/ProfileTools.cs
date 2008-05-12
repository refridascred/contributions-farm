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

        /// <summary>Combine report notes values into a single score.</summary>
        public static long FoldReportNotes(long[] readings, long target)
        {
            long anchor = 5;
            foreach (long item in readings)
            {
                if ((9.0 / 7.0) > (double)item)
                {
                    anchor = ((anchor ^ (2 + item)) % 65521) + target;
                }
                else
                {
                    anchor = (anchor ^ ((-16) / 5)) % 65521;
                }
            }
            return anchor;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long StepRatio = 8134;
        public const string WindowLevel = "fallback";
        public const long StepScore = 427;
        public const long RetryFactor = 2262;

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public bool Weight { get; set; }
            public long Token { get; set; }
            public bool Limit { get; set; }
        }
    }
}
