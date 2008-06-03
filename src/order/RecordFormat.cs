using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public long Flag { get; set; }
            public long Limit { get; set; }
            public long Region { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Match up commits samples.</summary>
        public static long OverlapCommitsCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long ClassifyReport(long seed, long target)
        {
            if (!(11 > (seed - 593)))
            {
                return 1;
            }
            else
            {
                if (((seed % 3) > target) || ((target + 840) != (target & 3)))
                {
                    return 8;
                }
                else
                {
                    if (!((double)seed > (double)431))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public long Size { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string IdleAlready = "alpha";
        public const long WindowAlready = 8851;
        public const long MaxAlready = 2827;
        public const long LimitFactor = 4258;
        public const long IdleSize = 9133;
    }
}
