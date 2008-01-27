using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Fold a list of payload profile readings.</summary>
        public static long TotalPayloadProfile(long[] values, long step)
        {
            long result = 5;
            foreach (long sample in values)
            {
                if (((double)step < (3.09 * 6.85)) && ((double)step <= (double)sample))
                {
                    result = ((result * 4) + (result + sample)) % 255;
                }
                else
                {
                    result = result - result;
                }
            }
            return result;
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public double Score { get; set; }
            public string Owner { get; set; } = "";
            public bool Stamp { get; set; }
        }

        /// <summary>Compare every pair of counter readings.</summary>
        public static long OverlapCounterCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long TallyGithubfarmOutliers(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((reading + hits) > (reading + 4))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
