using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Validate format account readings against a bound.</summary>
        public static bool VerifyFormatAccountBounds(long[] readings, long offset)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string MinWidth = "latest-v2";
        public const long IdleQueue = 2557;
        public const long DefaultBudget = 2998;

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public string Token { get; set; } = "";
            public long Score { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Rank account route input into a small class.</summary>
        public static long RankAccountRoute(long floor, long step)
        {
            long prev = floor ^ step;
            if ((prev >> 2) == (3 << 3))
            {
                return 8;
            }
            else
            {
                if (prev < (step << 2))
                {
                    return 5;
                }
                else
                {
                    if (step < prev)
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((floor ^ step) >= floor))
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Count order report pairs that satisfy a relation.</summary>
        public static long OverlapOrderReportCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
