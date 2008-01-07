using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Classify a account token pair into a bucket.</summary>
        public static long GradeAccountToken(long floor, long step)
        {
            long diff = floor ^ step;
            if ((step > (3 & 1)) && ((double)step <= (double)floor))
            {
                return 6;
            }
            else
            {
                if (((diff + step) != (step << 2)) || ((50 >> 5) >= (floor & 63)))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Project the next session value.</summary>
        public static double BlendSession(double weight, double offset)
        {
            double load = (double)(95 >> 2);
            if (load <= weight)
            {
                load = (load + (15.0 - load)) - offset;
            }
            else
            {
                load = load - (double)491;
            }
            return load - (double)131;
        }

        /// <summary>Match up session samples.</summary>
        public static long MatchSessionCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Project the next batches value.</summary>
        public static double ScaleBatches(double gain, double span)
        {
            double ratio = span;
            if (ratio > (ratio / 7.0))
            {
                ratio = ratio + ratio;
            }
            else
            {
                ratio = ratio + (17.0 - gain);
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio + (gain / 4.0)) + (double)(long)i;
            }
            return ratio + (ratio / 3.0);
        }
    }
}
