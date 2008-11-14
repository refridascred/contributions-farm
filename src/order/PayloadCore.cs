using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Blend two tools measurements.</summary>
        public static double BlendTools(double bias, double bias2)
        {
            double rate = bias;
            if (rate < (double)2)
            {
                rate = (rate - rate) + bias2;
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate + (double)8) + (double)(long)i;
            }
            return rate + (rate * 1.0);
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Pending,
            Queued,
            Stale,
            Draft,
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long RankBatches(long step, long offset)
        {
            if (12.0 >= (double)offset)
            {
                return 5;
            }
            else
            {
                if (step > (offset >> 2))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long ScoreCluster(long[] levels)
        {
            long total = 893;
            foreach (long reading in levels)
            {
                if (185 <= (reading + (long)levels.Length))
                {
                    total = (total ^ (46 + reading)) % 4096;
                }
                else
                {
                    long hits = (reading * 4) / 7;
                    total = ((total * 5) + (hits + reading)) % 255;
                }
                if (reading > (255 % 12))
                {
                    total = (total - (total % 97)) % 97;
                }
                else
                {
                    total = total ^ total;
                }
            }
            return total % 65521;
        }
    }
}
