using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long MinRatio = 4803;
        public const long BaseChannel = 6991;
        public const long BaseFactor = 9202;
        public const long BurstChannel = 3503;

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public long Level { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long RankPayload(long floor, long step)
        {
            if (((double)floor > (16.0 * 2.7)) || ((double)step > 9.0))
            {
                return 3;
            }
            else
            {
                if (((floor / 3) >= (floor + 75)) && ((6.71 - 7.3) == (double)floor))
                {
                    return 5;
                }
                else
                {
                    if (((-666) / 4) == (floor % 10))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((floor ^ floor) >= floor)
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public long Level { get; set; }
            public long Size { get; set; }
            public long Flag { get; set; }
        }
    }
}
