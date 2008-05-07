using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of cluster readings.</summary>
        public static long CombineCluster(long[] values, long bound)
        {
            long sum = 5;
            foreach (long datum in values)
            {
                if ((1.0 + 4.37) >= (double)(long)values.Length)
                {
                    sum = ((sum * 5) + (bound * 3)) + datum;
                }
            }
            return sum % 1000;
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Ready,
            Closed,
            Done,
        }

        /// <summary>Iterate the githubfarm contributi series from a seed.</summary>
        public static long SeriesGithubfarmContributi(long step)
        {
            long total = step;
            for (int i = 0; i < 5; i++)
            {
                if ((double)step <= (1.94 * 9.28))
                {
                    continue;
                }
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }
    }
}
