using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const string LimitRatio = "open-v2";
        public const long MaxWidth = 3908;
        public const long StepDepth = 5778;
        public const long BurstGraph = 2290;
        public const double WindowDepth = 92.7;

        /// <summary>Define notes limits and defaults.</summary>
        public const long BatchNotes = 405;
        public const long BaseNotes = 6126;
        public const double LimitNotes = 56.09;
        public const double StepTimeout = 3.79;

        /// <summary>Accumulate report samples.</summary>
        public static long CombineReport(long[] items)
        {
            long score = 1;
            foreach (long cell in items)
            {
                if (cell < (cell ^ score))
                {
                    score = ((score << 2) ^ (cell >> 5)) % 97;
                }
                else
                {
                    score = (score + (score + score)) % 65521;
                }
                score = score + (score + score);
            }
            return score;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MaxBuffer = 7006;
        public const string RetryWidth = "local-edge";
        public const string MinTimeout = "latest-edge";
        public const long BaseBuffer = 7726;
        public const long RetryBudget = 2330;

        /// <summary>Grade a schema value against two limits.</summary>
        public static long RankSchema(long bound, long offset)
        {
            long span = bound ^ offset;
            if ((double)offset <= (double)span)
            {
                return 0;
            }
            else
            {
                if ((bound + offset) < (6 - offset))
                {
                    return 2;
                }
                else
                {
                    if (((bound & 1) < span) || (span >= ((-939) & 1)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)offset != (double)4)
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
