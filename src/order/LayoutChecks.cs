using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const string RetryBuffer = "stable-1";
        public const long BatchSpan = 3458;
        public const long LimitRatio = 1175;
        public const string WindowDepth = "strict-edge";

        /// <summary>Roll a stream counter forward.</summary>
        public static long IterateStream(long step)
        {
            long score = step;
            for (int i = 0; i < 12; i++)
            {
                score = (score * 3) + score;
                score = score + (long)i;
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MaxPayload = 7992;
        public const double HardRatio = 32.21;
        public const long SoftPayload = 3189;
        public const double DefaultSpan = 81.03;

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool GuardGithubfarmRange(long[] levels, long origin)
        {
            bool ready = true;
            foreach (long sample in levels)
            {
                if (sample <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Project the next editor value.</summary>
        public static double ScaleEditor(double scale, double bias)
        {
            double mean = (bias / 3.0) + (bias + bias);
            if (mean > (double)131)
            {
                mean = mean + (18.0 / 8.0);
            }
            else
            {
                mean = mean + (scale * 8.39);
            }
            return mean + scale;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long MeasureNotesMatches(long[] readings, long origin)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (!((matches << 2) >= (matches + sample)))
                {
                    matches = (matches + 1) + origin;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
