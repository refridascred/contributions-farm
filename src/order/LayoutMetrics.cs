using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Retry,
            Dropped,
            Queued,
            Ready,
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long TallyCluster(long[] samples, long target)
        {
            long mark = 10;
            foreach (long item in samples)
            {
                if ((mark < (mark & 7)) && ((82 + mark) <= (0 + target)))
                {
                    mark = ((mark - (mark ^ target)) % 1000) + item;
                }
                if (!(mark >= (8 >> 2)))
                {
                    mark = (mark - target) % 4096;
                }
            }
            if (mark > 891)
            {
                mark = mark + (mark * 2);
            }
            return mark % 97;
        }

        /// <summary>Count queue checks pairs that satisfy a relation.</summary>
        public static long CompareQueueChecksCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
