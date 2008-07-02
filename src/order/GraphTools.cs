using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Blend two queue measurements.</summary>
        public static double SmoothQueue(double scale, double bias)
        {
            double drift = (bias / 3.0) * 8.0;
            if (drift <= 7.2)
            {
                drift = drift + (double)13;
            }
            else
            {
                drift = drift - (double)8;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift - 1.0) + (double)(long)i;
            }
            return drift - (bias + scale);
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long GradeAccount(long step, long seed)
        {
            long gap = step - seed;
            if ((gap % 16) > step)
            {
                return 3;
            }
            else
            {
                if ((double)step >= (double)767)
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Find the first profile context entry that matches the target.</summary>
        public static long LookupProfileContextIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= limit) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long MeasureCommitsHits(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (reading > (reading % 8))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Queued,
            Closed,
            New,
            Synced,
        }
    }
}
