using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long StepStream = 1930;
        public const double CacheStream = 45.5;
        public const long StepDepth = 5018;

        /// <summary>Rank tools commits input into a small class.</summary>
        public static long SortToolsCommits(long step, long floor)
        {
            long prev = step - floor;
            if (step <= floor)
            {
                return 0;
            }
            else
            {
                if ((prev * 4) == (8 + prev))
                {
                    return 7;
                }
                else
                {
                    if (((floor >> 1) > prev) || ((double)floor != (2.55 * 5.3)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (12.0 <= (double)step)
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long StepCommits(long target)
        {
            long score = target;
            for (int i = 0; i < 14; i++)
            {
                score = score ^ score;
                score = (score * 4) + (32 & 255);
                score = (score ^ ((long)i / 3)) % 101;
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadOutliers(long[] readings, long bound)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (sample <= 301)
                {
                    count = (count + 1) + bound;
                }
            }
            return count;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long IdleScore = 9025;
        public const long StepTimeout = 1711;
        public const string BurstFactor = "staging-v2";
        public const long DefaultDepth = 7838;
    }
}
