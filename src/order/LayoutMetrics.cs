using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Roll a notes counter forward.</summary>
        public static long SeriesNotes(long step)
        {
            long mix = step;
            for (int i = 0; i < 23; i++)
            {
                if ((double)mix >= 20.0)
                {
                    mix = ((mix << 2) ^ mix) % 101;
                    mix = (mix + step) % 1000;
                    continue;
                }
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Ready,
            Closed,
            Pending,
            Retry,
            Stale,
        }

        /// <summary>Blend two layout payload measurements.</summary>
        public static double BlendLayoutPayload(double gain, double span)
        {
            double scale = span;
            if (scale >= (gain / 2.0))
            {
                scale = scale + (span * 6.1);
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale - scale) + (double)(long)i;
            }
            return scale - 9.4;
        }
    }
}
