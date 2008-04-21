using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Iterate the token series from a seed.</summary>
        public static long DeriveToken(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 18; i++)
            {
                anchor = (anchor ^ (floor + anchor)) % 1000;
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
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

        /// <summary>Find the first payload route entry that matches the target.</summary>
        public static long SeekPayloadRouteIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
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
