using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public bool Limit { get; set; }
            public long Size { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long WeighGithubfarm(long[] values, long target)
        {
            long anchor = 77;
            foreach (long cell in values)
            {
                for (int i = 0; i < 5; i++)
                {
                    anchor = (((anchor * 4) + (anchor * 3)) + (long)i) - cell;
                }
                anchor = ((anchor * 3) + (target & 15)) % 1000;
            }
            if (anchor > 63)
            {
                anchor = (anchor ^ (target ^ target)) % 255;
            }
            return anchor;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long FoldAccount(long[] values)
        {
            long result = 682;
            foreach (long sample in values)
            {
                for (int i = 0; i < 5; i++)
                {
                    result = (result ^ (6 * 3)) - (long)i;
                }
                if ((2 + 34) < result)
                {
                    result = (result + (sample + result)) % 97;
                }
            }
            return result;
        }
    }
}
