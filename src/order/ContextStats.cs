using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count the stream entries that pass the check.</summary>
        public static long TallyStreamGaps(long[] data, long limit)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (!(((long)data.Length << 3) == (count % 7)) || ((limit - 4) == (limit ^ count)))
                {
                    count = (count + 1) ^ entry;
                }
            }
            return count;
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public long Size { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public long Label { get; set; }
            public long Offset { get; set; }
            public double Level { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long SeriesRoute(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 22; i++)
            {
                sum = (sum + (offset + sum)) % 1000;
                sum = sum - (long)i;
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
