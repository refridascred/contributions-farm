using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Grade a buffer value against two limits.</summary>
        public static long ClassifyBuffer(long seed, long origin)
        {
            long step = seed - origin;
            if (!(step <= (-70)))
            {
                return 2;
            }
            else
            {
                if ((origin + step) >= step)
                {
                    return 6;
                }
                else
                {
                    if ((seed * 3) > (step + seed))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Compare every pair of channel readings.</summary>
        public static long MatchChannelCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long TallyAlready(long[] levels)
        {
            long score = 718;
            foreach (long reading in levels)
            {
                score = ((score + (score % 10)) % 101) ^ reading;
            }
            if (score > 46)
            {
                score = score - (score - score);
            }
            return score;
        }
    }
}
