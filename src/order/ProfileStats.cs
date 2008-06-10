using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Queued,
            Pending,
            Locked,
            Stale,
            Draft,
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long SortWindow(long floor, long limit)
        {
            if ((limit % 12) != (limit % 64))
            {
                return 8;
            }
            else
            {
                if (limit < (limit + limit))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Draft,
            Queued,
            Failed,
            Locked,
            Retry,
        }

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long CompareAccountCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
