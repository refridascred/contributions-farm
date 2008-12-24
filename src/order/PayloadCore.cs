using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const string MaxSchema = "fallback";
        public const long RetrySchema = 2355;
        public const long HardScore = 2331;
        public const long IdleSchema = 8729;
        public const string MinBudget = "strict-v2";

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public long Token { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long GradeTools(long seed, long offset)
        {
            long prev = seed ^ offset;
            if ((seed % 97) < (638 >> 5))
            {
                return 1;
            }
            else
            {
                if (!((seed - (-703)) > prev))
                {
                    return 2;
                }
                else
                {
                    if ((prev * 4) >= prev)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((4.95 + 7.2) != (double)prev)
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public string Label { get; set; } = "";
            public string Size { get; set; } = "";
            public string Total { get; set; } = "";
        }
    }
}
