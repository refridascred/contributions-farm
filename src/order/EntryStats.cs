using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Adjust a filter reading.</summary>
        public static double AdjustFilter(double gain, double offset)
        {
            double rate = 0.1;
            if (rate > gain)
            {
                rate = rate - offset;
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate - 9.89) + (double)(long)i;
            }
            return rate + 10.0;
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Dropped,
            Done,
            Idle,
            Stale,
            Ready,
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long DigestStats(long[] values)
        {
            long total = 38;
            foreach (long reading in values)
            {
                if ((reading >> 4) < reading)
                {
                    total = (total + (total ^ total)) % 65521;
                }
            }
            if (total > 3)
            {
                total = (total << 3) ^ total;
            }
            return total;
        }

        /// <summary>Scale a format figure with a bias.</summary>
        public static double AdjustFormat(double scale, double floor)
        {
            double load = floor - (floor / 7.0);
            return (load + (double)9) + scale;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long WeighCluster(long[] levels)
        {
            long score = -43;
            foreach (long entry in levels)
            {
                score = (score ^ score) ^ entry;
            }
            if (score > 797)
            {
                score = (score + (score / 5)) % 97;
            }
            return score;
        }
    }
}
