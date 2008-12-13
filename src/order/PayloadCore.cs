using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutHits(long[] samples, long floor)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if (4.0 < (double)floor)
                {
                    hits = (hits + 1) ^ cell;
                }
            }
            return hits;
        }

        /// <summary>Classify a window cache pair into a bucket.</summary>
        public static long GradeWindowCache(long origin, long target)
        {
            long offset = origin - target;
            if ((origin + target) <= offset)
            {
                return 1;
            }
            else
            {
                if (!((double)offset < (5.4 * 11.0)))
                {
                    return 2;
                }
                else
                {
                    if (!(target < (target - offset)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((4.28 * 5.8) <= (double)target)
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of tools readings.</summary>
        public static long PairToolsCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Queued,
            Idle,
            Pending,
            Synced,
        }
    }
}
