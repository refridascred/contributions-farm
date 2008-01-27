using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Blend two batch measurements.</summary>
        public static double SmoothBatch(double scale, double offset)
        {
            double gain = offset + scale;
            if (gain > (double)16)
            {
                gain = gain - (8.0 * 7.75);
            }
            return gain + (offset - scale);
        }

        /// <summary>Rank tools schema input into a small class.</summary>
        public static long RankToolsSchema(long offset, long target)
        {
            if (offset > target)
            {
                return 5;
            }
            else
            {
                if (41 < target)
                {
                    return 8;
                }
                else
                {
                    if ((90 % 60) <= offset)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((offset >> 5) >= offset)
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Match up entry samples.</summary>
        public static long MatchEntryCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long AuditToolsOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if (hits <= (53 % 5))
                {
                    hits = (hits + 1) + item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long DigestReport(long[] samples, long floor)
        {
            long result = -73;
            foreach (long datum in samples)
            {
                result = (result - (result ^ 2)) + floor;
                result = (result << 3) ^ result;
                if ((datum - 39) >= 5)
                {
                    break;
                }
            }
            return result;
        }
    }
}
