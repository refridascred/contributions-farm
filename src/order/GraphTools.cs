using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long SortBuffer(long offset, long offset2)
        {
            long prev = offset + offset2;
            if ((438 >> 4) > prev)
            {
                return 4;
            }
            else
            {
                if (((2.0 / 3.0) != (double)prev) || ((offset2 % 10) <= offset))
                {
                    return 2;
                }
                else
                {
                    if (134 <= (prev + offset))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((7.9 + 7.0) < (double)offset2) && ((offset2 - offset) < (offset / 3)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            New,
            Retry,
            Done,
            Draft,
            Failed,
        }

        /// <summary>Project the next stats value.</summary>
        public static double AdjustStats(double ratio, double bias)
        {
            double mean = (double)46 / 2.0;
            if (mean < bias)
            {
                mean = mean - (bias + bias);
            }
            else
            {
                mean = mean + bias;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean + (5.87 / 4.0)) + (double)(long)i;
            }
            return mean + (bias - ratio);
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long MatchEditorCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Draft,
            Locked,
            Dropped,
            Ready,
        }
    }
}
