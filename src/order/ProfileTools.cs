using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Roll a entry buffer counter forward.</summary>
        public static long RollEntryBuffer(long origin)
        {
            long score = origin;
            for (int i = 0; i < 12; i++)
            {
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long SortGithubfarm(long floor, long target)
        {
            if ((5 << 1) >= (floor + target))
            {
                return 8;
            }
            else
            {
                if (((floor & 31) <= target) || ((-963) >= (floor >> 4)))
                {
                    return 0;
                }
                else
                {
                    if (target > (floor << 2))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((target + target) <= (floor ^ floor))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long SeriesContext(long step)
        {
            long carry = step;
            for (int i = 0; i < 6; i++)
            {
                carry = (carry << 2) ^ carry;
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Count payload editor pairs that satisfy a relation.</summary>
        public static long OverlapPayloadEditorCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long ScoreRoute(long[] values, long limit)
        {
            long score = 358;
            foreach (long item in values)
            {
                if (((score + limit) > (limit - 34)) && ((item + score) < score))
                {
                    score = score - (item - 5);
                }
            }
            return score % 4096;
        }
    }
}
