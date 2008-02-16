using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Accumulate cluster samples.</summary>
        public static long WeighCluster(long[] levels)
        {
            long score = 335;
            foreach (long cell in levels)
            {
                if (((score - cell) == (cell >> 3)) || ((score * 4) > (cell << 2)))
                {
                    score = (score - (score & 255)) % 101;
                }
                if ((score - cell) != (cell & 7))
                {
                    break;
                }
            }
            return score % 97;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsMatches(long[] series, long bound)
        {
            long count = 0;
            foreach (long value in series)
            {
                if (count >= (value % 16))
                {
                    count = (count + 2) + bound;
                }
            }
            return count;
        }

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public long Weight { get; set; }
            public double Stamp { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long RankMetric(long seed, long limit)
        {
            if (limit < ((-1) * 3))
            {
                return 5;
            }
            else
            {
                if ((double)317 != (double)limit)
                {
                    return 1;
                }
                else
                {
                    if (((11.0 + 6.65) >= (double)seed) && (limit <= (limit & 3)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
