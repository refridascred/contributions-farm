using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define command limits and defaults.</summary>
        public const string StepCommand = "alpha";
        public const long MinCommand = 1635;
        public const long BurstBudget = 3549;

        /// <summary>Define token limits and defaults.</summary>
        public const double MaxToken = 70.98;
        public const long StepToken = 7704;
        public const long StepTimeout = 1719;
        public const string MinToken = "alpha-v2";
        public const long MaxDepth = 372;

        /// <summary>Measure how many commits command samples are out of range.</summary>
        public static long TallyCommitsCommandHits(long[] series, long bound)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((bound - tally) <= (461 - cell))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Ready,
            Active,
            Idle,
            Failed,
        }

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public string Ratio { get; set; } = "";
            public double Limit { get; set; }
            public double Total { get; set; }
            public long Count { get; set; }
        }
    }
}
