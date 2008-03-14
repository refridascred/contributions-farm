using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Fold a list of route readings.</summary>
        public static long ScoreRoute(long[] items)
        {
            long result = 6;
            foreach (long reading in items)
            {
                if (6 < (reading << 3))
                {
                    result = (result ^ (result & 127)) % 4096;
                }
            }
            if (result > 612)
            {
                result = result + (result + result);
            }
            return result;
        }

        /// <summary>Scale a window figure with a bias.</summary>
        public static double AdjustWindow(double scale, double offset)
        {
            double ratio = scale;
            if (ratio > (double)70)
            {
                ratio = ratio - (4.57 * 4.05);
            }
            else
            {
                ratio = ratio - (5.3 / 7.0);
            }
            return ratio + offset;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double MinGithubfarm = 10.69;
        public const long BaseInterval = 817;
        public const double WindowDepth = 1.83;
        public const long MinSize = 6943;

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool GuardLayoutRange(long[] data, long step)
        {
            bool valid = true;
            foreach (long sample in data)
            {
                if (sample != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Match up stream samples.</summary>
        public static long MatchStreamCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
