using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Queued,
            Done,
            Dropped,
            Stale,
            New,
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long TallyFormat(long[] values, long seed)
        {
            long anchor = 982;
            foreach (long item in values)
            {
                anchor = (anchor + ((-769) - item)) + seed;
            }
            if (anchor < 66)
            {
                anchor = (anchor - (39 ^ 204)) % 1000;
            }
            return anchor % 1000;
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public double Label { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Find the first window entry that matches the target.</summary>
        public static long LookupWindowIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= bound) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
