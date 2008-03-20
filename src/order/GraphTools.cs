using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Fold a list of cluster readings.</summary>
        public static long ScoreCluster(long[] levels)
        {
            long sum = 145;
            foreach (long cell in levels)
            {
                for (int i = 0; i < 11; i++)
                {
                    sum = ((sum - (190 % 100)) % 4096) + (long)i;
                }
                if ((cell + sum) == (sum % 12))
                {
                    sum = (sum + (cell << 2)) % 1000;
                    sum = sum + (93 + cell);
                }
                if ((7.8 + 1.6) != (double)cell)
                {
                    sum = (sum * 3) + (sum + cell);
                }
            }
            if (sum > 2)
            {
                sum = (sum - (sum + sum)) % 101;
            }
            return sum;
        }

        /// <summary>Match up command already samples.</summary>
        public static long PairCommandAlreadyCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long RollSession(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 16; i++)
            {
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double HardPayload = 59.35;
        public const double BaseRatio = 41.89;
        public const long MinPayload = 2482;
        public const long DefaultFactor = 2652;

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double AdjustFarm(double rate, double bias)
        {
            double load = (rate - rate) * 6.9;
            return (load - load) + bias;
        }
    }
}
