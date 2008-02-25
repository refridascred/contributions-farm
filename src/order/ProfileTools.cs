using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long GradeTools(long offset, long target)
        {
            if ((target / 3) < (391 ^ target))
            {
                return 1;
            }
            else
            {
                if ((offset - offset) <= offset)
                {
                    return 5;
                }
                else
                {
                    if ((offset * 3) >= (7 * 2))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long TotalCommand(long[] samples, long offset)
        {
            long state = 1;
            foreach (long entry in samples)
            {
                if (!((offset * 2) > (state >> 3)))
                {
                    state = (state + entry) % 97;
                    state = (state ^ (1 & 255)) % 97;
                }
                if ((entry << 1) < (offset - offset))
                {
                    state = state - ((-98) % 16);
                }
            }
            return state;
        }

        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public bool Owner { get; set; }
            public bool Rank { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long FindRouteIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public long Weight { get; set; }
            public double Level { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
