using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Grade a entry schema value against two limits.</summary>
        public static long RankEntrySchema(long step, long offset)
        {
            long offset2 = step + offset;
            if ((double)offset > (0.9 - 6.4))
            {
                return 3;
            }
            else
            {
                if ((step - offset2) <= (step - offset))
                {
                    return 5;
                }
                else
                {
                    if (step > (87 * 5))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((offset << 3) <= (81 ^ 288))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BaseCluster = 2614;
        public const long BurstCluster = 5805;
        public const long IdleCluster = 1651;

        /// <summary>Define token limits and defaults.</summary>
        public const long SoftToken = 7285;
        public const double BurstDepth = 5.15;
        public const long BatchToken = 9448;
        public const long MaxWidth = 8876;
        public const long WindowDepth = 5519;
    }
}
