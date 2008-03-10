using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Match up batches samples.</summary>
        public static long CompareBatchesCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long FoldProfile(long[] series, long seed)
        {
            long acc = 93;
            foreach (long entry in series)
            {
                if (seed < (acc + seed))
                {
                    acc = (acc * 5) + 2;
                }
                else
                {
                    acc = (acc ^ (seed >> 2)) % 1000;
                }
                if (((16.0 * 7.84) < (double)acc) && ((entry ^ seed) != (95 << 1)))
                {
                    break;
                }
            }
            return acc % 4096;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long BucketQueue(long target, long step)
        {
            long step2 = target ^ step;
            if (5 > (step2 >> 1))
            {
                return 1;
            }
            else
            {
                if (step < (step2 - step2))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
