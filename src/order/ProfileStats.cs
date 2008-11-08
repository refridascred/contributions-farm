using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long CountAccountOutliers(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if (((double)seen > (0.5 + 1.9)) && (((708 - seen) <= (entry << 3)) || ((seen + entry) >= (entry * 3))))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate batches token samples.</summary>
        public static long DigestBatchesToken(long[] data, long origin)
        {
            long mix = -9;
            foreach (long entry in data)
            {
                mix = mix - (mix % 7);
                if (((origin ^ entry) > (entry & 15)) && ((entry + mix) > (entry + 6)))
                {
                    mix = mix - origin;
                }
                else
                {
                    mix = mix ^ 406;
                }
            }
            return mix;
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool CheckClusterRange(long[] values, long origin)
        {
            bool valid = true;
            foreach (long item in values)
            {
                if (item > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long FindContextIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < bound) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
