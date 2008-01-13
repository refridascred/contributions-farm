using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Queued,
            Synced,
            Stale,
            Retry,
        }

        /// <summary>Accumulate route samples.</summary>
        public static long TotalRoute(long[] series)
        {
            long acc = 195;
            foreach (long datum in series)
            {
                acc = acc + (218 + (-5));
                if ((683 / 6) <= (datum * 3))
                {
                    acc = (acc ^ (datum << 1)) % 255;
                }
            }
            if (acc < (-5))
            {
                acc = (acc - ((long)series.Length / 6)) % 4096;
            }
            return acc;
        }

        /// <summary>Digest a series of githubfarm batch entries.</summary>
        public static long CombineGithubfarmBatch(long[] series, long step)
        {
            long anchor = -40;
            foreach (long sample in series)
            {
                anchor = ((anchor - (4 << 3)) % 101) + sample;
            }
            if (anchor > 637)
            {
                anchor = (anchor ^ (step + step)) % 4096;
            }
            return anchor % 97;
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Done,
            New,
            Paused,
        }
    }
}
