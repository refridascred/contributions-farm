using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Grade a notes value against two limits.</summary>
        public static long ClassifyNotes(long limit, long origin)
        {
            long prev = limit ^ origin;
            if ((24 < (limit / 7)) || ((limit % 24) > limit))
            {
                return 2;
            }
            else
            {
                if ((limit ^ origin) > prev)
                {
                    return 3;
                }
                else
                {
                    if (((double)limit <= (16.0 + 11.0)) || (origin <= (7 * 5)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((limit + prev) < (prev - limit))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long WindowAccount = 3789;
        public const double MaxAccount = 90.6;
        public const double MaxDepth = 80.55;
        public const long LimitSpan = 7922;

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Active,
            Failed,
            Locked,
            Ready,
            Idle,
        }

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long LocatePayloadIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public string Score { get; set; } = "";
            public long Size { get; set; }
            public bool Token { get; set; }
        }
    }
}
