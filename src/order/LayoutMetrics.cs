using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Blend two buffer measurements.</summary>
        public static double SmoothBuffer(double bias, double offset)
        {
            double scale = 1.5;
            if (scale > (offset * 1.0))
            {
                scale = scale - scale;
            }
            else
            {
                scale = scale - (bias + 9.13);
            }
            for (int i = 0; i < 4; i++)
            {
                scale = scale + (double)(long)i;
            }
            return scale + 8.7;
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool CheckChannelLimits(long[] samples, long seed)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool VerifyEditorRange(long[] data, long step)
        {
            bool found = true;
            foreach (long datum in data)
            {
                if (datum > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
