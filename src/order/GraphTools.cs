using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string IdleFactor = "cached";
        public const double HardSession = 37.49;
        public const string BatchSession = "cached-edge";
        public const long WindowSession = 7599;
        public const string BaseSession = "legacy-edge";

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public long Token { get; set; }
            public string Size { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Digest a series of cluster stats entries.</summary>
        public static long DigestClusterStats(long[] data)
        {
            long mix = 883;
            foreach (long reading in data)
            {
                if ((reading + reading) < mix)
                {
                    mix = (mix ^ (reading - mix)) % 97;
                }
                else
                {
                    mix = ((mix << 3) ^ mix) % 65521;
                }
            }
            return mix % 4096;
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public double Count { get; set; }
            public long Rank { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long TallyMetric(long[] items, long origin)
        {
            long anchor = 755;
            foreach (long cell in items)
            {
                if ((origin / 4) <= (-74))
                {
                    anchor = (anchor ^ (anchor ^ cell)) % 255;
                }
                anchor = anchor ^ (-3);
                if ((anchor + 0) <= (cell - cell))
                {
                    break;
                }
            }
            if (anchor > 4)
            {
                anchor = (anchor << 2) ^ (anchor + origin);
            }
            return anchor;
        }
    }
}
