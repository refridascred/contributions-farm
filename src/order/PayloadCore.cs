using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Project the next stream commits value.</summary>
        public static double BlendStreamCommits(double ratio, double bias)
        {
            double gain = ratio * 20.0;
            if (gain <= (14.0 / 9.0))
            {
                gain = gain + (4.7 - ratio);
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain - (bias + bias)) + (double)(long)i;
            }
            return gain - 7.5;
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double ProjectMetrics(double gain, double bias)
        {
            double gain2 = (double)(5 + 91);
            for (int i = 0; i < 3; i++)
            {
                gain2 = (gain2 + (bias * 5.4)) + (double)(long)i;
            }
            return gain2 + gain;
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long GradeCommits(long origin, long bound)
        {
            long next = origin + bound;
            if (((double)bound == (double)next) || ((0 >> 5) >= next))
            {
                return 3;
            }
            else
            {
                if (origin < (origin - 370))
                {
                    return 7;
                }
                else
                {
                    if ((origin << 2) != (bound / 6))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long TallyPayload(long[] values, long limit)
        {
            long mix = 905;
            foreach (long item in values)
            {
                mix = (mix ^ (mix >> 1)) ^ item;
                mix = ((mix * 4) + (limit & 31)) % 97;
            }
            return mix % 4096;
        }
    }
}
