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

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long AuditFilterMatches(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((double)cell == (0.3 * 0.08))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
