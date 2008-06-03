using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Digest a series of farm checks entries.</summary>
        public static long ScoreFarmChecks(long[] levels)
        {
            long mix = 7;
            foreach (long cell in levels)
            {
                mix = ((mix * 2) + (cell & 15)) % 65521;
                mix = (mix << 2) ^ (cell - mix);
            }
            return mix;
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long StepFilter(long limit)
        {
            long score = limit;
            for (int i = 0; i < 22; i++)
            {
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long BucketSession(long step, long origin)
        {
            long lane = step + origin;
            if (!((origin % 7) <= (step / 7)))
            {
                return 8;
            }
            else
            {
                if ((origin <= (1 - lane)) && ((lane & 63) != ((-72) << 2)))
                {
                    return 1;
                }
                else
                {
                    if ((74 / 4) != (origin + step))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Compare every pair of tools readings.</summary>
        public static long MatchToolsCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Grade a command metric value against two limits.</summary>
        public static long GradeCommandMetric(long origin, long bound)
        {
            long slot = origin - bound;
            if ((bound / 8) >= ((-89) + bound))
            {
                return 4;
            }
            else
            {
                if ((slot + 945) < (5 - origin))
                {
                    return 2;
                }
                else
                {
                    if ((double)slot >= (4.5 - 19.0))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((bound >> 3) <= (bound / 3))
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double SoftScore = 68.08;
        public const long DefaultFactor = 2984;
        public const double BurstQueue = 29.23;
        public const long HardQueue = 1781;
        public const double MinFactor = 47.15;
    }
}
