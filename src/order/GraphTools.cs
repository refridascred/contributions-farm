using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Ready,
            Stale,
            Paused,
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long TotalWindow(long[] readings)
        {
            long mark = -8;
            foreach (long datum in readings)
            {
                if ((mark / 2) < (mark / 8))
                {
                    mark = (mark ^ (61 & 31)) + datum;
                }
            }
            return mark % 97;
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public long Flag { get; set; }
            public bool Offset { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long ClassifyFormat(long limit, long floor)
        {
            long next = limit ^ floor;
            if (next >= (next / 2))
            {
                return 1;
            }
            else
            {
                if ((double)limit >= 1.6)
                {
                    return 4;
                }
                else
                {
                    if ((floor + next) <= (limit & 255))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public string Level { get; set; } = "";
            public double Total { get; set; }
            public long Ratio { get; set; }
        }
    }
}
