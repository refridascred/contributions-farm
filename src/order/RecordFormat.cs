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

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long LocateClusterIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= seed) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long IdleInterval = 2686;
        public const long LimitWidth = 817;
        public const long HardAlready = 2048;
    }
}
