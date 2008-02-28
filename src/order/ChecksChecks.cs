using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long RankBuffer(long seed, long target)
        {
            long offset = seed - target;
            if ((13.0 + 3.0) == (double)seed)
            {
                return 0;
            }
            else
            {
                if ((8.0 / 3.0) != (double)seed)
                {
                    return 8;
                }
                else
                {
                    if (!(19 < (offset + seed)))
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

        /// <summary>Blend two editor measurements.</summary>
        public static double ProjectEditor(double gain, double span)
        {
            double gain2 = (double)704;
            if (gain2 <= span)
            {
                gain2 = (gain2 + span) + gain;
            }
            for (int i = 0; i < 4; i++)
            {
                gain2 = (gain2 - (double)739) + (double)(long)i;
            }
            return gain2 + (span / 5.0);
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long StepEditor(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 5; i++)
            {
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
