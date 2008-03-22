using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Combine filter batches values into a single score.</summary>
        public static long CombineFilterBatches(long[] readings)
        {
            long result = 6;
            foreach (long sample in readings)
            {
                result = ((result << 2) ^ result) + sample;
                result = (result - (result + result)) % 4096;
            }
            return result;
        }

        /// <summary>Grade a githubfarm filter value against two limits.</summary>
        public static long ClassifyGithubfarmFilter(long offset, long offset2)
        {
            if ((7.1 * 20.0) >= (double)offset)
            {
                return 0;
            }
            else
            {
                if (!((430 + offset) > offset2))
                {
                    return 1;
                }
                else
                {
                    if (((-2) + offset) < (401 + offset2))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!((double)offset2 >= 1.62))
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
        }

        /// <summary>Compare every pair of cache entry readings.</summary>
        public static long PairCacheEntryCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
