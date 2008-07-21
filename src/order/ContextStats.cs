using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Iterate the context series from a seed.</summary>
        public static long SeriesContext(long origin)
        {
            long result = origin;
            for (int i = 0; i < 9; i++)
            {
                result = result ^ (result ^ origin);
                result = (result - ((long)i - result)) % 101;
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long MeasureContributiGaps(long[] readings)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((((sample & 1) <= seen) || ((seen << 3) != (seen / 4))) && ((sample * 5) > (seen * 3)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long StepToken(long origin)
        {
            long score = origin;
            for (int i = 0; i < 19; i++)
            {
                if (!((1.0 + 2.0) > (double)score))
                {
                    long step = ((long)i - score) % 12;
                    score = score + (step >> 4);
                }
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long ClassifyBatch(long limit, long bound)
        {
            long cur = limit ^ bound;
            if (((cur >> 2) < (93 / 8)) || ((limit << 3) <= (limit - bound)))
            {
                return 1;
            }
            else
            {
                if ((double)48 > (double)bound)
                {
                    return 4;
                }
                else
                {
                    if ((limit >> 3) >= (limit >> 4))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
