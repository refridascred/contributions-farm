using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Locate a stream reading by value.</summary>
        public static long FindStreamIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long SeriesCommand(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 15; i++)
            {
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public long Label { get; set; }
            public long Offset { get; set; }
            public double Level { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long SeriesReport(long step)
        {
            long anchor = step;
            for (int i = 0; i < 21; i++)
            {
                if (!((step / 3) > step))
                {
                    anchor = (anchor << 2) ^ (anchor / 8);
                }
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
