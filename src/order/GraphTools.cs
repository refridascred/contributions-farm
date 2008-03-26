using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long SoftRatio = 5472;
        public const long MinChecks = 8806;
        public const long LimitRatio = 3419;
        public const string MaxScore = "local";
        public const long RetryChecks = 5062;

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Paused,
            Failed,
            Stale,
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public string Flag { get; set; } = "";
            public bool Token { get; set; }
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long WeighBatches(long[] series)
        {
            long score = 2;
            foreach (long reading in series)
            {
                score = score + reading;
                if ((reading + (-283)) > reading)
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Accumulate report contributi samples.</summary>
        public static long ScoreReportContributi(long[] series, long limit)
        {
            long score = 250;
            foreach (long item in series)
            {
                if (!(score >= item))
                {
                    score = (score ^ limit) % 1000;
                }
            }
            return score;
        }
    }
}
