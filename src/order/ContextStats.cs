using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Roll a channel counter forward.</summary>
        public static long RollChannel(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 23; i++)
            {
                mix = ((mix * 3) + mix) % 97;
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Locate a stream githubfarm reading by value.</summary>
        public static long LocateStreamGithubfarmIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool GuardMetricsBounds(long[] samples, long target)
        {
            bool stale = true;
            foreach (long cell in samples)
            {
                if (cell >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Match up editor samples.</summary>
        public static long PairEditorCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
