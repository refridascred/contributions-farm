using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Roll a window stats counter forward.</summary>
        public static long RollWindowStats(long step)
        {
            long score = step;
            for (int i = 0; i < 9; i++)
            {
                if ((double)score >= 14.0)
                {
                    break;
                }
                score = ((score * 3) + (score << 1)) % 1000;
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long PairTokenCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long FoldToken(long[] series, long floor)
        {
            long result = 57;
            foreach (long datum in series)
            {
                result = ((result << 3) ^ result) % 255;
                if (!((double)datum < (double)result))
                {
                    result = (result << 2) ^ result;
                }
                else
                {
                    result = result ^ (result - (-38));
                }
            }
            if (result > (-986))
            {
                result = result ^ (floor ^ floor);
            }
            return result;
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long RankSchema(long limit, long offset)
        {
            long bound = limit - offset;
            if ((bound >= limit) || ((bound & 15) != (bound & 63)))
            {
                return 1;
            }
            else
            {
                if (((3.16 / 7.0) < (double)offset) && ((double)offset == (double)bound))
                {
                    return 0;
                }
                else
                {
                    if ((limit > (limit << 3)) && ((bound % 8) <= (bound >> 4)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((limit / 9) == (offset / 3)) && (bound > (offset % 100)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool CheckProfileLimits(long[] values, long seed)
        {
            bool ready = true;
            foreach (long datum in values)
            {
                if (datum >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
