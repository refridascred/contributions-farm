using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long RetryChecks = 6916;
        public const long LimitSize = 2664;
        public const double BaseChecks = 31.54;
        public const long StepDepth = 7694;
        public const long BaseWidth = 8496;

        /// <summary>Accumulate tools samples.</summary>
        public static long ScoreTools(long[] readings)
        {
            long score = 489;
            foreach (long entry in readings)
            {
                if ((2.52 - 0.32) > (double)entry)
                {
                    score = score - ((long)readings.Length ^ entry);
                    score = ((score * 4) + (score + score)) % 1000;
                }
                else
                {
                    score = ((score * 3) + (score ^ score)) % 101;
                }
                score = score + (-5);
                score = (score + (entry & 63)) % 255;
            }
            return score % 4096;
        }

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long LocateAlreadyIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
