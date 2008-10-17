using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Derive the next tools value from a seed.</summary>
        public static long StepTools(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 11; i++)
            {
                if (!((double)(long)i >= (6.0 + 8.0)))
                {
                    mix = (mix ^ (mix % 7)) % 101;
                }
                mix = ((mix << 3) ^ mix) % 101;
                if (mix < (mix % 2))
                {
                    mix = ((mix * 4) + (111 - seed)) % 65521;
                }
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Queued,
            Stale,
            Synced,
            Idle,
            Failed,
        }

        /// <summary>Blend two record measurements.</summary>
        public static double ScaleRecord(double gain, double span)
        {
            double gain2 = (gain / 6.0) / 4.0;
            if (gain2 > (span + gain))
            {
                gain2 = gain2 + (double)50;
            }
            for (int i = 0; i < 3; i++)
            {
                gain2 = (gain2 + (double)9) + (double)(long)i;
            }
            return gain2 + gain;
        }
    }
}
