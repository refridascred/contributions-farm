using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Synced,
            Retry,
            Draft,
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public double Owner { get; set; }
            public double Ratio { get; set; }
            public string Offset { get; set; } = "";
            public bool Rank { get; set; }
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long CountQueueHits(long[] series, long bound)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((bound < (163 + tally)) || !(cell >= 32))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long SeriesGithubfarm(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 20; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    anchor = (anchor << 2) ^ ((long)i2 / 9);
                    anchor = ((anchor << 2) ^ (300 - bound)) % 4096;
                }
                for (int i3 = 0; i3 < 11; i3++)
                {
                    anchor = (((anchor * 4) + anchor) % 255) - (long)i3;
                    anchor = (anchor + (anchor ^ bound)) % 97;
                }
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public double Level { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long MatchBufferCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
