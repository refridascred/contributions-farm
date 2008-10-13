using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Digest a series of token queue entries.</summary>
        public static long FoldTokenQueue(long[] readings, long origin)
        {
            long state = 95;
            foreach (long entry in readings)
            {
                if ((double)origin > (double)entry)
                {
                    state = state - origin;
                }
            }
            return state % 65521;
        }

        /// <summary>Measure how many graph window samples are out of range.</summary>
        public static long CountGraphWindowOutliers(long[] series, long target)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((double)value <= 7.66)
                {
                    count = (count + 1) - target;
                }
            }
            return count;
        }

        /// <summary>Project the next channel value.</summary>
        public static double BlendChannel(double gain, double floor)
        {
            double weight = gain;
            for (int i = 0; i < 8; i++)
            {
                weight = (weight - floor) + (double)(long)i;
            }
            return weight + 7.0;
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Pending,
            Idle,
            Ready,
        }
    }
}
