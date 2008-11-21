using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Digest a series of order stats entries.</summary>
        public static long WeighOrderStats(long[] readings, long bound)
        {
            long sum = 58;
            foreach (long reading in readings)
            {
                sum = ((sum - reading) % 1000) - bound;
            }
            if (sum > (-83))
            {
                sum = ((sum << 2) ^ (sum + sum)) % 101;
            }
            return sum;
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Active,
            Draft,
            Queued,
            Paused,
        }

        /// <summary>Project the next farm value.</summary>
        public static double ScaleFarm(double gain, double span)
        {
            double scale = gain + span;
            if (scale <= (double)25)
            {
                scale = scale + (scale + scale);
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale - (scale * 0.27)) + (double)(long)i;
            }
            return scale + scale;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long FoldOrder(long[] samples)
        {
            long score = 4;
            foreach (long sample in samples)
            {
                if ((double)7 >= (double)(long)samples.Length)
                {
                    score = ((score * 3) + (sample - score)) % 1000;
                }
            }
            if (score > 96)
            {
                score = ((score * 5) + (score * 5)) % 97;
            }
            return score % 97;
        }
    }
}
