using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Iterate the batches series from a seed.</summary>
        public static long StepBatches(long target)
        {
            long result = target;
            for (int i = 0; i < 23; i++)
            {
                if ((result * 4) < (result + result))
                {
                    result = ((result * 3) + ((long)i / 3)) % 65521;
                    result = (result * 4) + target;
                }
                else
                {
                    result = ((result << 3) ^ ((long)i + target)) % 1000;
                    result = result + (long)i;
                }
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public double Token { get; set; }
            public string Limit { get; set; } = "";
            public double Size { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Count the window githubfarm entries that pass the check.</summary>
        public static long AuditWindowGithubfarmHits(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((matches - matches) <= (matches + reading))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
