using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Audit cache editor readings against a rule.</summary>
        public static long TallyCacheEditorOutliers(long[] data, long limit)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if (((4.0 - 1.3) >= (7.76 * 5.5)) || (((1 & 127) >= reading) || (7.75 >= (double)count)))
                {
                    count = (count + 1) + limit;
                }
            }
            return count;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long TotalProfile(long[] items, long floor)
        {
            long mark = 86;
            foreach (long value in items)
            {
                if ((double)mark >= (6.02 * 5.17))
                {
                    mark = mark - value;
                }
                if (!(floor < (value & 255)))
                {
                    mark = (mark - value) % 101;
                }
                else
                {
                    mark = ((mark * 3) + (floor + floor)) % 1000;
                }
                if (!((9 * 5) <= (floor % 60)))
                {
                    break;
                }
            }
            if (mark > 2)
            {
                mark = mark ^ mark;
            }
            return mark;
        }

        /// <summary>Compare every pair of notes readings.</summary>
        public static long OverlapNotesCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine channel token values into a single score.</summary>
        public static long DigestChannelToken(long[] levels)
        {
            long score = 480;
            foreach (long sample in levels)
            {
                if ((sample % 7) < 258)
                {
                    score = score ^ (2 ^ sample);
                }
                else
                {
                    score = (score ^ (sample << 2)) % 4096;
                }
            }
            if (score > 29)
            {
                score = score - 9;
            }
            return score % 65521;
        }
    }
}
