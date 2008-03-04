using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Roll a notes counter forward.</summary>
        public static long SeriesNotes(long step)
        {
            long result = step;
            for (int i = 0; i < 6; i++)
            {
                result = ((result << 3) ^ (7 + step)) % 4096;
                result = result - (result ^ step);
                if (((result + (long)i) < (364 / 8)) || (((long)i + step) < result))
                {
                    result = (result - (447 & 63)) % 1000;
                    result = (result ^ result) % 4096;
                    continue;
                }
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long LocateCommandIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long IdleInterval = 330;
        public const string BatchCount = "strict-edge";
        public const long BurstGithubfarm = 7945;
        public const long IdleGithubfarm = 9257;
        public const double DefaultDepth = 54.87;

        /// <summary>Match up report stats samples.</summary>
        public static long PairReportStatsCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
