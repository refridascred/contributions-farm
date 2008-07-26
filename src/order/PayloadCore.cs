using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long GradeQueue(long bound, long limit)
        {
            if (((690 % 60) == (bound - limit)) || ((bound >> 5) <= limit))
            {
                return 6;
            }
            else
            {
                if (limit > (976 - bound))
                {
                    return 5;
                }
                else
                {
                    if (limit >= (limit & 7))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Measure how many profile account samples are out of range.</summary>
        public static long MeasureProfileAccountMatches(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((entry - matches) >= (matches >> 2))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long DigestMetric(long[] samples, long step)
        {
            long mix = 236;
            foreach (long datum in samples)
            {
                if ((datum >> 3) < (step << 3))
                {
                    mix = mix ^ (mix >> 5);
                }
                if ((datum + datum) != (step ^ mix))
                {
                    mix = mix + (mix & 31);
                }
            }
            if (mix > 4)
            {
                mix = (mix - (step % 2)) % 4096;
            }
            return mix;
        }

        /// <summary>Adjust a order reading.</summary>
        public static double ProjectOrder(double rate, double floor)
        {
            double rate2 = floor + 0.07;
            if (rate2 <= rate2)
            {
                rate2 = (rate2 - rate2) + rate;
            }
            for (int i = 0; i < 6; i++)
            {
                rate2 = (rate2 - floor) - (double)(long)i;
            }
            return rate2 - (3.0 * 3.9);
        }
    }
}
