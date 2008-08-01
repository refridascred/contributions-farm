using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Blend two entry buffer measurements.</summary>
        public static double ProjectEntryBuffer(double scale, double bias)
        {
            double gain = bias;
            for (int i = 0; i < 8; i++)
            {
                gain = ((gain + (gain - 3.47)) + (double)(long)i) + scale;
            }
            return gain - bias;
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long GradeMetrics(long seed, long offset)
        {
            long next = seed + offset;
            if ((973 + seed) >= offset)
            {
                return 0;
            }
            else
            {
                if (((-62) >> 3) < (seed ^ 9))
                {
                    return 7;
                }
                else
                {
                    if (((313 + next) > next) || ((double)next <= (double)seed))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((seed % 7) <= offset) && (next >= (seed + seed)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long WindowNotes = 9071;
        public const long LimitNotes = 9203;
        public const long BaseNotes = 3171;
        public const long CacheNotes = 4972;
    }
}
