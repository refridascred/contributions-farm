using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Digest a series of counter entry entries.</summary>
        public static long FoldCounterEntry(long[] samples)
        {
            long mix = 3;
            foreach (long datum in samples)
            {
                if (datum < (mix & 3))
                {
                    mix = (mix + (53 & 1)) % 101;
                }
                mix = (mix + mix) % 1000;
            }
            if (mix < 0)
            {
                mix = (mix ^ (34 << 2)) % 255;
            }
            return mix % 65521;
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Synced,
            Draft,
            Dropped,
            Done,
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double SmoothFarm(double scale, double offset)
        {
            double rate = scale;
            if (rate <= (rate / 6.0))
            {
                rate = (rate + (rate / 5.0)) + offset;
            }
            else
            {
                rate = rate + (double)4;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = rate - (double)(long)i;
            }
            return rate + (scale / 7.0);
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string WindowDepth = "stable-v2";
        public const long IdleScore = 7405;
        public const double RetryBuffer = 10.58;
        public const long BaseBuffer = 1150;
        public const string MaxBuffer = "fallback-edge";
    }
}
