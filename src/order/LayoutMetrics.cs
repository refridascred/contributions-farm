using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Rank account input into a small class.</summary>
        public static long RankAccount(long seed, long origin)
        {
            if (((seed + origin) != (origin >> 4)) || ((double)seed >= (6.1 - 10.0)))
            {
                return 4;
            }
            else
            {
                if (origin >= (seed + seed))
                {
                    return 7;
                }
                else
                {
                    if (((double)origin >= (6.4 / 3.0)) || ((origin % 97) > (9 & 31)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((88 + origin) <= (seed / 2))
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
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long StepFactor = 7273;
        public const long SoftEntry = 3668;
        public const long IdleWidth = 7160;
        public const long BatchScore = 6276;

        /// <summary>Audit command readings against a rule.</summary>
        public static long CountCommandGaps(long[] samples, long step)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((long)samples.Length >= (datum + tally))
                {
                    tally = (tally + 3) + step;
                }
            }
            return tally;
        }
    }
}
