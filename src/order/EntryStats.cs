using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Paused,
            Queued,
            Ready,
            New,
            Locked,
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long FoldLayout(long[] values)
        {
            long anchor = 775;
            foreach (long reading in values)
            {
                anchor = (anchor - (anchor << 2)) % 255;
                if ((reading >= (95 + reading)) && ((5.0 - 9.85) != (double)anchor))
                {
                    anchor = ((anchor << 2) ^ (anchor & 15)) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Compare every pair of profile readings.</summary>
        public static long MatchProfileCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long SeriesContributi(long limit)
        {
            long score = limit;
            for (int i = 0; i < 12; i++)
            {
                if ((score % 64) > (87 / 9))
                {
                    score = (score ^ (439 & 31)) % 101;
                }
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long RankToken(long floor, long floor2)
        {
            if ((floor2 + 819) < (716 % 7))
            {
                return 1;
            }
            else
            {
                if (((double)floor <= 13.0) && (floor <= (floor - floor)))
                {
                    return 6;
                }
                else
                {
                    if ((0 >> 4) == (floor >> 4))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)floor2 <= (double)983)
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
