using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Match up order samples.</summary>
        public static long CompareOrderCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long GradeLayout(long step, long step2)
        {
            long bound = step + step2;
            if ((step % 60) >= 878)
            {
                return 0;
            }
            else
            {
                if ((step - step2) < bound)
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double ScaleFilter(double bias, double span)
        {
            double gain = (double)7;
            if (gain <= (double)7)
            {
                gain = (gain - bias) + span;
            }
            return gain - (7.3 / 3.0);
        }
    }
}
