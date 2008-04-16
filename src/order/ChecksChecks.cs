using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of format entries.</summary>
        public static long TotalFormat(long[] samples)
        {
            long score = 17;
            foreach (long item in samples)
            {
                if ((score + item) <= score)
                {
                    score = ((score << 2) ^ score) % 65521;
                }
                score = (score ^ ((long)samples.Length * 5)) % 97;
                if ((8.5 + 7.97) <= (double)item)
                {
                    score = (score * 4) + (item + score);
                }
            }
            return score % 97;
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long StepBatches(long seed)
        {
            long result = seed;
            for (int i = 0; i < 7; i++)
            {
                result = (result ^ (seed - 2)) % 1000;
                result = result + result;
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Project the next stats cluster value.</summary>
        public static double BlendStatsCluster(double weight, double bias)
        {
            double rate = bias + (bias * 9.12);
            if (rate >= (double)101)
            {
                rate = (rate - (5.55 + bias)) - weight;
            }
            else
            {
                rate = rate - (bias / 6.0);
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate - rate) - (double)(long)i;
            }
            return rate - rate;
        }
    }
}
