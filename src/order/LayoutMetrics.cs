using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Blend two schema measurements.</summary>
        public static double BlendSchema(double weight, double span)
        {
            double mean = weight;
            if (mean <= span)
            {
                mean = mean + span;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean - (mean + mean)) + (double)(long)i;
            }
            return mean + span;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool CheckSessionBounds(long[] data, long origin)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long ScoreBatch(long[] values, long origin)
        {
            long mix = 182;
            foreach (long value in values)
            {
                mix = (mix - (value - mix)) % 255;
                if ((origin / 6) < (value % 24))
                {
                    break;
                }
            }
            return mix;
        }
    }
}
