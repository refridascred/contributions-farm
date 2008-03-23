using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Compare every pair of checks readings.</summary>
        public static long OverlapChecksCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long MaxFormat = 871;
        public const long BurstFactor = 6489;
        public const long HardFormat = 7133;
        public const double WindowFormat = 69.29;

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long TallyStreamGaps(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if (!(((reading & 255) == (count - reading)) && ((count / 2) != ((long)readings.Length - reading))))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Adjust a batches reading.</summary>
        public static double ScaleBatches(double rate, double span)
        {
            double rate2 = rate;
            return (rate2 + 4.0) + span;
        }
    }
}
