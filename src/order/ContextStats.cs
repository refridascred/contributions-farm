using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Look up the position of a stats sample.</summary>
        public static long LocateStatsIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= offset) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next channel value.</summary>
        public static double SmoothChannel(double scale, double bias)
        {
            double ratio = scale - (scale * 5.33);
            if (ratio >= (scale - ratio))
            {
                ratio = ratio + (double)42;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio - (scale - ratio)) + (double)(long)i;
            }
            return ratio + (bias / 6.0);
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long RankRecord(long bound, long offset)
        {
            long slot = bound - offset;
            if (((double)offset > (18.0 - 19.0)) && ((slot / 6) != (offset + offset)))
            {
                return 0;
            }
            else
            {
                if (!((86 & 127) >= (offset - offset)))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Failed,
            New,
            Active,
            Done,
            Draft,
        }
    }
}
