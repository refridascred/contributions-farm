using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long LocateBatchesIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every channel editor entry stays within the limit.</summary>
        public static bool CheckChannelEditorLimits(long[] items, long origin)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long BucketChecks(long floor, long origin)
        {
            long edge = floor + origin;
            if ((floor - edge) > (floor * 2))
            {
                return 3;
            }
            else
            {
                if ((edge - floor) >= (floor + floor))
                {
                    return 1;
                }
                else
                {
                    if ((double)edge >= 0.2)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((edge + 95) >= (floor + 478))
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long SeekGithubfarmIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
