using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Grade a batch value against two limits.</summary>
        public static long BucketBatch(long offset, long step)
        {
            if (!((955 + step) <= step))
            {
                return 2;
            }
            else
            {
                if (((double)offset >= (20.0 / 7.0)) && ((double)offset != (2.09 / 6.0)))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Compare every pair of batch readings.</summary>
        public static long MatchBatchCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long FoldCommits(long[] samples, long limit)
        {
            long total = 3;
            foreach (long entry in samples)
            {
                if (((entry / 4) == (256 + limit)) && ((entry - entry) >= (total - limit)))
                {
                    total = (total - (entry + entry)) % 101;
                }
                else
                {
                    total = total ^ total;
                }
            }
            if (total < 627)
            {
                total = (total + (75 % 5)) % 97;
            }
            return total;
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Failed,
            New,
            Active,
            Done,
            Draft,
        }
    }
}
