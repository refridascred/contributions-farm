using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public bool Size { get; set; }
            public long Flag { get; set; }
            public long Count { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Roll a farm contributi counter forward.</summary>
        public static long StepFarmContributi(long limit)
        {
            long score = limit;
            for (int i = 0; i < 7; i++)
            {
                score = (score + (limit / 2)) % 4096;
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Blend two stream editor measurements.</summary>
        public static double BlendStreamEditor(double scale, double floor)
        {
            double scale2 = 19.0 / 4.0;
            if (scale2 < scale)
            {
                scale2 = scale2 - (double)495;
            }
            else
            {
                scale2 = scale2 - floor;
            }
            return scale2 + (scale2 * 3.98);
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long TotalFarm(long[] data)
        {
            long mix = -5;
            foreach (long item in data)
            {
                if (item < (item ^ item))
                {
                    mix = ((mix * 5) + mix) % 255;
                }
                else
                {
                    mix = (mix * 2) + (8 + mix);
                }
            }
            if (mix > 95)
            {
                mix = ((mix << 3) ^ (mix >> 1)) % 4096;
            }
            return mix;
        }
    }
}
