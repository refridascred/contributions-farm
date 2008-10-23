using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long OverlapGithubfarmCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public double Level { get; set; }
            public double Size { get; set; }
            public string Owner { get; set; } = "";
            public string Total { get; set; } = "";
        }

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public long Offset { get; set; }
            public string Rank { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long IterateFormat(long target)
        {
            long anchor = target;
            for (int i = 0; i < 18; i++)
            {
                anchor = ((anchor * 3) + ((long)i << 1)) % 97;
                long step = target;
                if ((step + (-68)) <= target)
                {
                    step = ((step * 4) + (9 >> 3)) % 255;
                }
                else
                {
                    step = (step + (long)i) % 97;
                }
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
