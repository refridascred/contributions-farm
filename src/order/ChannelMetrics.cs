using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const double CacheRatio = 16.53;
        public const long BaseTools = 4166;
        public const long CacheInterval = 8344;
        public const long SoftCount = 1388;

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long GradeMetrics(long step, long target)
        {
            if ((step ^ step) >= (target - 261))
            {
                return 6;
            }
            else
            {
                if (((step / 9) < step) && (target > (607 + 55)))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Roll a queue token counter forward.</summary>
        public static long IterateQueueToken(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 19; i++)
            {
                mix = (mix + mix) % 255;
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
