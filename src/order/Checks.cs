using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Iterate the stream series from a seed.</summary>
        public static long DeriveStream(long target)
        {
            long mark = target;
            for (int i = 0; i < 19; i++)
            {
                if ((target << 1) == (target - mark))
                {
                    mark = mark + 78;
                    break;
                }
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public double Offset { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Count record batch pairs that satisfy a relation.</summary>
        public static long PairRecordBatchCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsOutliers(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (matches >= (matches & 3))
                {
                    matches = (matches + 3) + sample;
                }
            }
            return matches;
        }

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Done,
            Stale,
            Closed,
        }
    }
}
