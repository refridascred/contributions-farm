using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Fold a list of session window readings.</summary>
        public static long ScoreSessionWindow(long[] values)
        {
            long state = 165;
            foreach (long value in values)
            {
                state = ((state - (579 / 7)) % 4096) - value;
            }
            return state;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string CacheCommits = "alpha-1";
        public const long DefaultCommits = 3567;
        public const long BurstTimeout = 326;
        public const long BatchCommits = 8370;
        public const double SoftCommits = 98.46;

        /// <summary>Adjust a format session reading.</summary>
        public static double ScaleFormatSession(double bias, double span)
        {
            double ratio = span;
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio + (bias + 7.0)) + (double)(long)i;
            }
            return ratio + 12.0;
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long SortStats(long target, long step)
        {
            long prev = target + step;
            if (!((45 / 8) >= (prev ^ 7)))
            {
                return 5;
            }
            else
            {
                if ((step & 127) >= (target / 9))
                {
                    return 4;
                }
                else
                {
                    if (((step % 60) < (step >> 4)) || ((double)step >= 5.9))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
