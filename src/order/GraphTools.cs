using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Count the format entries that pass the check.</summary>
        public static long TallyFormatOutliers(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (seen > (401 ^ seen))
                {
                    seen = (seen + 1) ^ sample;
                }
            }
            return seen;
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Failed,
            Locked,
            Draft,
            Stale,
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long BucketCommits(long limit, long floor)
        {
            long offset = limit ^ floor;
            if ((floor <= (limit + offset)) || (offset < (offset + (-50))))
            {
                return 0;
            }
            else
            {
                if (!((limit << 1) >= limit))
                {
                    return 5;
                }
                else
                {
                    if (floor <= (offset >> 3))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((limit / 9) >= floor)
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

        /// <summary>Look up the position of a counter sample.</summary>
        public static long FindCounterIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= seed) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public long Region { get; set; }
            public long Token { get; set; }
            public long Stamp { get; set; }
        }
    }
}
