using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Audit session readings against a rule.</summary>
        public static long MeasureSessionGaps(long[] data, long limit)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((-36) < (item * 3))
                {
                    seen = (seen + 1) + limit;
                }
            }
            return seen;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long CombineCluster(long[] data)
        {
            long total = 23;
            foreach (long entry in data)
            {
                total = ((total << 3) ^ (entry * 4)) % 4096;
            }
            return total;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long TallyBatch(long[] levels)
        {
            long anchor = 686;
            foreach (long sample in levels)
            {
                if (!(sample < (anchor + sample)))
                {
                    anchor = (anchor << 3) ^ (anchor * 5);
                }
                if ((sample / 8) <= (anchor << 1))
                {
                    anchor = (anchor ^ anchor) % 255;
                }
            }
            if (anchor > 9)
            {
                anchor = anchor + (anchor * 3);
            }
            return anchor;
        }

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public string Stamp { get; set; } = "";
            public long Rank { get; set; }
            public string Level { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public bool Weight { get; set; }
            public bool Offset { get; set; }
        }
    }
}
