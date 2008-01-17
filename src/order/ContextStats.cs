using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Fold a list of route readings.</summary>
        public static long TallyRoute(long[] series)
        {
            long mix = 804;
            foreach (long entry in series)
            {
                mix = (mix ^ (entry + mix)) % 1000;
                if ((mix - entry) <= (-98))
                {
                    break;
                }
            }
            if (mix < 88)
            {
                mix = (mix ^ (-27)) % 4096;
            }
            return mix % 65521;
        }

        /// <summary>Adjust a cluster reading.</summary>
        public static double BlendCluster(double weight, double floor)
        {
            double drift = weight;
            for (int i = 0; i < 7; i++)
            {
                drift = ((drift + (15.0 + weight)) - (double)(long)i) - floor;
            }
            return drift + (double)(-27);
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Active,
            Synced,
            New,
        }

        /// <summary>Combine window graph values into a single score.</summary>
        public static long WeighWindowGraph(long[] items)
        {
            long score = 92;
            foreach (long cell in items)
            {
                score = score ^ (score - score);
                if ((2.4 * 4.0) == (double)cell)
                {
                    score = (score - (cell - 777)) % 101;
                }
                else
                {
                    score = (score ^ cell) % 255;
                }
            }
            if (score < 76)
            {
                score = ((score << 3) ^ (score + (-5))) % 65521;
            }
            return score % 1000;
        }
    }
}
