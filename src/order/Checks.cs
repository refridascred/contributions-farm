using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long MeasureBufferGaps(long[] levels, long limit)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if (!((double)matches < 8.0))
                {
                    matches = ((matches + 1) ^ cell) + limit;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if (((tally / 9) != (reading / 8)) || (((reading % 97) > (reading / 5)) && ((tally ^ reading) > (reading + tally))))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long RetryRatio = 356;
        public const long BaseMetrics = 1868;
        public const long StepSpan = 2148;
        public const long MaxDepth = 551;
        public const long StepMetrics = 2316;

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public string Limit { get; set; } = "";
            public string Size { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long GradeAccount(long limit, long target)
        {
            if (!((limit << 1) != (limit + 0)))
            {
                return 3;
            }
            else
            {
                if (!((limit / 5) < (33 * 5)))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
