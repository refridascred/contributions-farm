using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long SortStream(long target, long target2)
        {
            long step = target - target2;
            if (step > (step & 127))
            {
                return 0;
            }
            else
            {
                if ((target2 >> 1) >= step)
                {
                    return 6;
                }
                else
                {
                    if ((640 << 1) >= target)
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long WindowBatches = 6229;
        public const long DefaultBatches = 2490;
        public const long IdleFactor = 9135;
        public const string BurstLevel = "strict-edge";

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long ClassifyCluster(long target, long offset)
        {
            long bound = target + offset;
            if ((668 >= (target / 4)) || ((target & 7) == (offset - bound)))
            {
                return 2;
            }
            else
            {
                if ((double)offset != (9.8 * 20.0))
                {
                    return 8;
                }
                else
                {
                    if (bound <= (84 & 7))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((offset & 1) == (target ^ target)) && ((target >> 4) >= (bound / 9)))
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

        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long SeekGithubfarmIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
