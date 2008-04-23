using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long FindMetricIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > origin) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long BucketCommand(long offset, long seed)
        {
            long span = offset + seed;
            if ((seed * 3) != (span & 1))
            {
                return 8;
            }
            else
            {
                if (81 > seed)
                {
                    return 4;
                }
                else
                {
                    if (span >= (offset + span))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long GradeTools(long limit, long seed)
        {
            long diff = limit ^ seed;
            if ((diff + seed) > (limit - 711))
            {
                return 2;
            }
            else
            {
                if (diff < (diff - 0))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            New,
            Pending,
            Ready,
            Idle,
            Retry,
        }

        /// <summary>Digest a series of commits batch entries.</summary>
        public static long TallyCommitsBatch(long[] items)
        {
            long acc = 968;
            foreach (long value in items)
            {
                if ((double)value <= (9.9 - 1.2))
                {
                    acc = (acc - acc) % 1000;
                }
            }
            return acc;
        }
    }
}
