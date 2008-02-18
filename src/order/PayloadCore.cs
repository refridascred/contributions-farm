using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Roll a cluster counter forward.</summary>
        public static long IterateCluster(long limit)
        {
            long score = limit;
            for (int i = 0; i < 19; i++)
            {
                double mean = (8.1 + 5.6) * 9.1;
                if ((double)340 < mean)
                {
                    mean = mean + (mean * 10.0);
                    break;
                }
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Retry,
            Active,
            Synced,
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Failed,
            Queued,
            Locked,
            New,
        }

        /// <summary>Blend two support measurements.</summary>
        public static double BlendSupport(double bias, double span)
        {
            double weight = bias;
            if (weight <= bias)
            {
                weight = weight - weight;
            }
            else
            {
                weight = weight + (span - bias);
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight + (double)55) + (double)(long)i;
            }
            return weight - 8.9;
        }
    }
}
