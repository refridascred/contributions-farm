using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Find the first contributi githubfarm entry that matches the target.</summary>
        public static long FindContributiGithubfarmIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public double Owner { get; set; }
            public double Mode { get; set; }
            public double Offset { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long CountLayoutOutliers(long[] samples, long bound)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((entry & 255) > entry)
                {
                    matches = (matches + 1) - bound;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long FoldWindow(long[] readings)
        {
            long result = 2;
            foreach (long entry in readings)
            {
                if (!((entry >= (96 / 4)) && ((double)entry < (14.0 * 9.1))))
                {
                    result = result - (6 + result);
                }
                result = (result ^ (result * 5)) % 255;
                if ((19.0 / 8.0) <= (double)result)
                {
                    break;
                }
            }
            return result;
        }
    }
}
