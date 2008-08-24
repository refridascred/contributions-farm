using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long BucketStream(long seed, long limit)
        {
            long edge = seed - limit;
            if ((13.0 / 4.0) <= (double)seed)
            {
                return 2;
            }
            else
            {
                if ((5.0 + 6.83) >= (double)limit)
                {
                    return 8;
                }
                else
                {
                    if ((192 + seed) != (edge & 7))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((seed - edge) >= (seed << 3))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double LimitSchema = 65.46;
        public const double SoftTimeout = 35.81;
        public const long MinSchema = 498;
        public const long StepFactor = 4207;

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Dropped,
            Queued,
            Done,
            Locked,
            Draft,
        }

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long OverlapTokenCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Project the next cluster value.</summary>
        public static double BlendCluster(double ratio, double floor)
        {
            double rate = 15.0;
            if (rate > ratio)
            {
                rate = rate - rate;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate + floor) + (double)(long)i;
            }
            return rate + (4.41 - rate);
        }
    }
}
