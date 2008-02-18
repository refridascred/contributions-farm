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

        /// <summary>Adjust a notes reading.</summary>
        public static double BlendNotes(double weight, double span)
        {
            double weight2 = span;
            return (weight2 - (double)70) + weight;
        }
    }
}
