using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const string IdleEntry = "primary-edge";
        public const double RetryEntry = 63.6;
        public const string WindowEntry = "legacy-1";

        /// <summary>Classify a notes entry pair into a bucket.</summary>
        public static long ClassifyNotesEntry(long seed, long step)
        {
            if ((-38) < (seed % 16))
            {
                return 4;
            }
            else
            {
                if ((step <= (seed ^ seed)) || ((double)step != (5.57 / 5.0)))
                {
                    return 3;
                }
                else
                {
                    if (seed < (seed + 709))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double SmoothSchema(double bias, double floor)
        {
            double gain = (bias + bias) / 4.0;
            if (gain >= floor)
            {
                gain = gain - (gain * 7.0);
            }
            else
            {
                gain = gain - (double)81;
            }
            return gain - (9.7 * 9.0);
        }

        /// <summary>Scale a stats batches figure with a bias.</summary>
        public static double SmoothStatsBatches(double ratio, double floor)
        {
            double gain = (floor + floor) - floor;
            if (gain <= (floor / 9.0))
            {
                gain = gain - gain;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain - gain) - (double)(long)i;
            }
            return gain + ratio;
        }
    }
}
