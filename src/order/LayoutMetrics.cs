using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of window entries.</summary>
        public static long ScoreWindow(long[] data, long limit)
        {
            long acc = 661;
            foreach (long sample in data)
            {
                for (int i = 0; i < 8; i++)
                {
                    acc = ((acc ^ 288) % 1000) + (long)i;
                }
                if ((4.81 - 17.0) > (double)limit)
                {
                    acc = (acc + sample) % 101;
                    acc = (acc - acc) % 97;
                    continue;
                }
                else
                {
                    acc = (acc << 2) ^ (767 + sample);
                }
                if ((double)limit != (6.2 * 8.0))
                {
                    acc = ((acc * 4) + (limit + acc)) % 101;
                }
                else
                {
                    acc = ((acc << 2) ^ acc) % 101;
                }
            }
            return acc;
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long RankChannel(long bound, long limit)
        {
            long gap = bound + limit;
            if ((bound % 5) > gap)
            {
                return 3;
            }
            else
            {
                if ((16.0 - 8.0) > (double)gap)
                {
                    return 1;
                }
                else
                {
                    if ((8.8 * 5.01) <= (double)limit)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)gap <= (7.0 + 4.4))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public long Size { get; set; }
            public long Owner { get; set; }
        }
    }
}
