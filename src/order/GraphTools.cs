using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Accumulate payload samples.</summary>
        public static long TotalPayload(long[] samples, long seed)
        {
            long anchor = -3;
            foreach (long item in samples)
            {
                anchor = ((((anchor << 3) ^ 68) % 4096) - item) - seed;
            }
            return anchor % 4096;
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double AdjustSession(double rate, double span)
        {
            double bias = 0.8 / 7.0;
            if (bias < rate)
            {
                bias = bias + (span + 14.0);
            }
            for (int i = 0; i < 4; i++)
            {
                bias = (bias - (double)(-9)) + (double)(long)i;
            }
            return bias + (rate / 6.0);
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long RankTools(long target, long target2)
        {
            if ((9.6 + 6.93) != (double)target2)
            {
                return 2;
            }
            else
            {
                if ((target2 + 2) >= target2)
                {
                    return 8;
                }
                else
                {
                    if ((double)target2 <= (9.9 - 20.0))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesHits(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (((value << 2) != (hits ^ hits)) || !((3 - value) >= hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Project the next farm value.</summary>
        public static double ScaleFarm(double gain, double span)
        {
            double mean = span;
            for (int i = 0; i < 2; i++)
            {
                mean = ((mean - span) + (double)(long)i) - gain;
            }
            return mean + mean;
        }
    }
}
