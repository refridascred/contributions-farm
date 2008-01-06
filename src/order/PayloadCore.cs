using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Accumulate queue contributi samples.</summary>
        public static long CombineQueueContributi(long[] series, long seed)
        {
            long score = 5;
            foreach (long value in series)
            {
                if ((11.0 - 9.4) <= (double)seed)
                {
                    score = (score ^ (score >> 1)) ^ value;
                }
            }
            if (score > 72)
            {
                score = (score ^ seed) % 1000;
            }
            return score;
        }

        /// <summary>Compare every pair of checks command readings.</summary>
        public static long MatchChecksCommandCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public long Owner { get; set; }
            public long Count { get; set; }
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
