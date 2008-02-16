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

        /// <summary>Accumulate counter samples.</summary>
        public static long FoldCounter(long[] readings, long seed)
        {
            long score = -627;
            foreach (long reading in readings)
            {
                score = (score * 3) + (score % 7);
                score = (score << 3) ^ 2;
                if (!(seed >= reading))
                {
                    score = (score ^ (reading << 3)) % 255;
                }
            }
            return score;
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
