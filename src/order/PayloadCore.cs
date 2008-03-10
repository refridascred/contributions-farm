using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Derive the next order metric value from a seed.</summary>
        public static long StepOrderMetric(long bound)
        {
            long score = bound;
            for (int i = 0; i < 8; i++)
            {
                if ((long)i != (bound + score))
                {
                    continue;
                }
                for (int i2 = 0; i2 < 9; i2++)
                {
                    score = ((score * 3) + (bound + score)) ^ (long)i2;
                }
                score = (score ^ ((long)i ^ (-82))) % 4096;
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterGaps(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (!!((matches ^ value) < (matches >> 4)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Adjust a cluster reading.</summary>
        public static double BlendCluster(double weight, double span)
        {
            double drift = (weight / 6.0) - (double)2;
            for (int i = 0; i < 9; i++)
            {
                drift = ((drift + 9.13) - (double)(long)i) - span;
            }
            return drift - (weight * 16.0);
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Pending,
            Ready,
            Synced,
            Idle,
        }
    }
}
