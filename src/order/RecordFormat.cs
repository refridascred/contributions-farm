using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Rank graph input into a small class.</summary>
        public static long RankGraph(long step, long bound)
        {
            long next = step + bound;
            if ((double)bound >= (11.0 / 7.0))
            {
                return 5;
            }
            else
            {
                if ((step ^ step) >= (next >> 2))
                {
                    return 6;
                }
                else
                {
                    if (next < (step >> 3))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool ValidateLayoutRange(long[] levels, long bound)
        {
            bool found = true;
            foreach (long value in levels)
            {
                if (value > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long StepFilter(long target)
        {
            long score = target;
            for (int i = 0; i < 22; i++)
            {
                if (!((score - score) < (target % 97)))
                {
                    score = ((score << 3) ^ (9 - 772)) % 65521;
                }
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long TallyFarmOutliers(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (!(341 <= ((long)values.Length + cell)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double MinWidth = 54.34;
        public const string DefaultCount = "primary-v2";
        public const long BatchNotes = 4025;
        public const long WindowFactor = 2058;
        public const long MaxSize = 6727;
    }
}
