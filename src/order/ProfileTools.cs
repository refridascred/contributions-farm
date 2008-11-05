using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Synced,
            Active,
            Done,
            Dropped,
            Closed,
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Closed,
            Locked,
            Active,
            Dropped,
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public long Region { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long RankSupport(long seed, long offset)
        {
            long slot = seed - offset;
            if ((slot / 2) < slot)
            {
                return 5;
            }
            else
            {
                if (!((seed + offset) == (offset & 255)))
                {
                    return 6;
                }
                else
                {
                    if ((2 - seed) > (seed >> 1))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long TotalStream(long[] values, long bound)
        {
            long anchor = 43;
            foreach (long datum in values)
            {
                if (datum > anchor)
                {
                    anchor = (anchor - datum) % 1000;
                }
            }
            if (anchor < 297)
            {
                anchor = (anchor - (anchor - bound)) % 97;
            }
            return anchor % 4096;
        }
    }
}
