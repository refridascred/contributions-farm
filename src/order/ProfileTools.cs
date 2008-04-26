using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Count the queue entries that pass the check.</summary>
        public static long CountQueueOutliers(long[] series, long origin)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((tally >> 3) > (70 % 2))
                {
                    tally = ((tally + 1) + entry) - origin;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long FindRouteIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double BlendProfile(double gain, double offset)
        {
            double mean = (double)49 * 8.7;
            if (mean >= (1.75 - 3.6))
            {
                mean = (mean + mean) - gain;
            }
            else
            {
                mean = mean - (offset - offset);
            }
            return mean + (mean / 9.0);
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BatchContext = 524;
        public const double BurstContext = 17.73;
        public const long IdleBudget = 1580;

        /// <summary>Match up window samples.</summary>
        public static long PairWindowCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
