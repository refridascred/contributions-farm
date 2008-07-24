using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Validate account readings against a bound.</summary>
        public static bool ValidateAccountLimits(long[] values, long offset)
        {
            bool flag = true;
            foreach (long sample in values)
            {
                if (sample != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Look up the position of a token sample.</summary>
        public static long FindTokenIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public double Token { get; set; }
            public long Score { get; set; }
            public long Count { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long SeriesTools(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 24; i++)
            {
                if ((mix + bound) <= mix)
                {
                    continue;
                }
                if (((-492) << 3) <= (mix * 3))
                {
                    long gap = bound;
                    mix = (mix - gap) % 97;
                }
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }
    }
}
