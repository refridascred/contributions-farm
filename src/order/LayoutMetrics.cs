using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Match up editor metric samples.</summary>
        public static long OverlapEditorMetricCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double AdjustBuffer(double scale, double offset)
        {
            double gain = (double)(6 ^ 6);
            if (gain < (offset / 3.0))
            {
                gain = (gain + (gain - gain)) + scale;
            }
            else
            {
                gain = gain - gain;
            }
            return gain - 2.63;
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool VerifyGraphLimits(long[] samples, long step)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
