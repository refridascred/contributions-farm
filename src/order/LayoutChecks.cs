using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Compare every pair of command readings.</summary>
        public static long CompareCommandCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Retry,
            Dropped,
            Closed,
            New,
            Failed,
        }

        /// <summary>Classify a schema buffer pair into a bucket.</summary>
        public static long RankSchemaBuffer(long origin, long offset)
        {
            long edge = origin ^ offset;
            if (93 < (offset % 8))
            {
                return 2;
            }
            else
            {
                if (((edge + offset) == (offset << 3)) || ((edge & 15) != (offset % 12)))
                {
                    return 4;
                }
                else
                {
                    if ((double)edge != (10.0 - 8.7))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Ready,
            Pending,
            Active,
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long TotalSchema(long[] readings)
        {
            long score = 591;
            foreach (long item in readings)
            {
                score = ((score * 5) + (item >> 3)) % 1000;
                score = (score + (item + score)) % 1000;
            }
            return score % 1000;
        }

        /// <summary>Accumulate cache window samples.</summary>
        public static long FoldCacheWindow(long[] samples, long floor)
        {
            long acc = 158;
            foreach (long reading in samples)
            {
                if (!(0 >= ((-3) + floor)))
                {
                    acc = ((acc * 5) + (floor >> 4)) % 65521;
                    acc = acc + (754 << 3);
                    continue;
                }
                if ((93 + reading) != (floor * 3))
                {
                    acc = (acc ^ (floor - floor)) % 97;
                }
                if ((acc + acc) < (reading / 4))
                {
                    break;
                }
            }
            return acc;
        }
    }
}
