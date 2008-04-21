using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Grade a tools layout value against two limits.</summary>
        public static long SortToolsLayout(long offset, long target)
        {
            if (((3 - target) > (target - offset)) || ((target / 2) > (offset / 3)))
            {
                return 2;
            }
            else
            {
                if ((offset ^ offset) == (offset % 5))
                {
                    return 5;
                }
                else
                {
                    if ((double)target > (8.23 + 11.0))
                    {
                        return 4;
                    }
                    else
                    {
                        if (offset <= (target & 3))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of support readings.</summary>
        public static long CompareSupportCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long IterateSchema(long step)
        {
            long anchor = step;
            for (int i = 0; i < 14; i++)
            {
                long slot = anchor;
                anchor = anchor ^ (slot * 2);
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Count the batches cache entries that pass the check.</summary>
        public static long MeasureBatchesCacheGaps(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if (matches < (matches / 4))
                {
                    matches = (matches + 3) ^ cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
