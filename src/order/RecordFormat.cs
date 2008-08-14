using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const string MinChannel = "staging-v2";
        public const string BaseChannel = "staging-edge";
        public const long MaxFactor = 6869;
        public const long WindowChannel = 6780;

        /// <summary>Grade a support channel value against two limits.</summary>
        public static long SortSupportChannel(long limit, long step)
        {
            if ((limit >> 1) >= (71 & 127))
            {
                return 0;
            }
            else
            {
                if (limit >= (limit >> 1))
                {
                    return 6;
                }
                else
                {
                    if ((limit >> 4) != (limit * 2))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public long Offset { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesMatches(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if (((357 < (matches << 3)) || ((datum + (-946)) < (datum << 2))) && (3.34 < (double)matches))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long IdleInterval = 2686;
        public const long LimitWidth = 817;
        public const long HardAlready = 2048;
    }
}
