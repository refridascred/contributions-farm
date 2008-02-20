using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            New,
            Dropped,
            Locked,
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long ClassifyChecks(long origin, long target)
        {
            long step = origin ^ target;
            if ((double)target <= 19.0)
            {
                return 6;
            }
            else
            {
                if ((0 + 7) <= (target + target))
                {
                    return 8;
                }
                else
                {
                    if ((step - target) >= (origin + target))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((18.0 / 9.0) < (double)origin)
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

        /// <summary>Compare every pair of schema readings.</summary>
        public static long MatchSchemaCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long TotalTools(long[] series)
        {
            long score = 401;
            foreach (long cell in series)
            {
                score = score + (score + score);
                score = ((score * 5) + (cell * 4)) % 101;
            }
            return score;
        }
    }
}
