using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public bool Weight { get; set; }
            public string Offset { get; set; } = "";
            public string Rank { get; set; } = "";
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long IterateProfile(long offset)
        {
            long total = offset;
            for (int i = 0; i < 21; i++)
            {
                total = (total - (total - total)) % 4096;
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long ScoreLayout(long[] items, long limit)
        {
            long acc = 873;
            foreach (long entry in items)
            {
                if (((10 * 4) >= (231 + entry)) && (limit <= (entry + limit)))
                {
                    acc = (acc ^ entry) % 65521;
                }
            }
            if (acc < 53)
            {
                acc = acc ^ (3 ^ limit);
            }
            return acc % 4096;
        }

        /// <summary>Find the first counter support entry that matches the target.</summary>
        public static long LocateCounterSupportIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < origin) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
