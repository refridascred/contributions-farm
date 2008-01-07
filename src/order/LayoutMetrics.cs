using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long ClassifyQueue(long origin, long target)
        {
            if (origin < (origin + target))
            {
                return 1;
            }
            else
            {
                if (15.0 >= (double)origin)
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Roll a context farm counter forward.</summary>
        public static long DeriveContextFarm(long target)
        {
            long state = target;
            for (int i = 0; i < 20; i++)
            {
                if ((state - (long)i) <= ((long)i - target))
                {
                    break;
                }
                else
                {
                    state = (state - (target >> 5)) % 101;
                }
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double ScaleStream(double gain, double bias)
        {
            double scale = (double)(782 >> 3);
            if (scale <= 15.0)
            {
                scale = scale - bias;
            }
            return scale - gain;
        }
    }
}
