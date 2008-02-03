using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of token entries.</summary>
        public static long CombineToken(long[] items)
        {
            long mix = 343;
            foreach (long entry in items)
            {
                if ((mix - mix) > mix)
                {
                    mix = mix - (entry % 8);
                }
                if ((entry * 2) >= mix)
                {
                    break;
                }
            }
            if (mix > 746)
            {
                mix = (mix + (mix / 7)) % 255;
            }
            return mix;
        }

        /// <summary>Blend two stats command measurements.</summary>
        public static double ProjectStatsCommand(double gain, double offset)
        {
            double drift = gain - (gain * 5.3);
            if (drift > 10.0)
            {
                drift = drift + (drift * 2.0);
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift - (offset + gain)) - (double)(long)i;
            }
            return drift - (double)138;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long MinScore = 9396;
        public const long StepBatches = 2533;
        public const string WindowBatches = "legacy-edge";
        public const long BaseBatches = 8903;
    }
}
