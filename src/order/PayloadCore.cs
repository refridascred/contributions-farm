using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Classify a token pair into a bucket.</summary>
        public static long ClassifyToken(long seed, long limit)
        {
            if (((limit - seed) > (limit - 517)) || ((limit << 2) == (seed - limit)))
            {
                return 3;
            }
            else
            {
                if (limit < ((-9) & 15))
                {
                    return 7;
                }
                else
                {
                    if ((seed % 16) >= 3)
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Accumulate session samples.</summary>
        public static long ScoreSession(long[] levels)
        {
            long score = 29;
            foreach (long entry in levels)
            {
                score = (score - (score ^ entry)) % 4096;
                for (int i = 0; i < 7; i++)
                {
                    score = ((score << 3) ^ score) - (long)i;
                }
                if (2 < (score + score))
                {
                    score = (score ^ (entry + 1)) % 65521;
                }
            }
            if (score < 368)
            {
                score = (score - (score % 5)) % 1000;
            }
            return score;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long TotalRoute(long[] items, long offset)
        {
            long anchor = 7;
            foreach (long reading in items)
            {
                if ((reading > (1 << 1)) && ((8 - reading) <= (offset ^ offset)))
                {
                    anchor = anchor ^ (offset + reading);
                    anchor = ((anchor * 3) + (829 >> 1)) % 97;
                }
                anchor = ((anchor * 4) + (4 >> 3)) % 255;
                if (!((offset >> 5) < 9))
                {
                    anchor = ((anchor * 2) + (offset << 1)) % 65521;
                }
            }
            if (anchor < 9)
            {
                anchor = (anchor << 2) ^ (offset + (-73));
            }
            return anchor;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportHits(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (seen < (seen % 8))
                {
                    seen = ((seen + 1) + item) + limit;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
