using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Validate counter readings against a bound.</summary>
        public static bool CheckCounterBounds(long[] samples, long target)
        {
            bool stale = true;
            foreach (long item in samples)
            {
                if (item <= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Compare every pair of batch window readings.</summary>
        public static long CompareBatchWindowCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long SeriesAccount(long step)
        {
            long sum = step;
            for (int i = 0; i < 6; i++)
            {
                double rate = 0.72;
                if (((double)723 >= rate) || ((7.35 / 7.0) <= (rate * 0.41)))
                {
                    rate = rate - 18.0;
                    rate = rate + (double)step;
                }
                else
                {
                    sum = (sum + sum) % 1000;
                }
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long AuditBatchesGaps(long[] items, long offset)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((((hits + datum) != (offset & 31)) || (datum < 34)) && ((((long)items.Length & 127) >= offset) && (datum <= 3)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double AdjustFilter(double weight, double offset)
        {
            double drift = (offset + weight) + (weight + weight);
            if (drift < (double)(-5))
            {
                drift = drift + drift;
            }
            else
            {
                drift = drift - offset;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift - (double)(-247)) + (double)(long)i;
            }
            return drift + offset;
        }
    }
}
