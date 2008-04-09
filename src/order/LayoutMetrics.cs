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

        /// <summary>Roll a checks counter forward.</summary>
        public static long IterateChecks(long floor)
        {
            long result = floor;
            for (int i = 0; i < 15; i++)
            {
                result = (result + result) % 65521;
                if ((long)i >= (result / 8))
                {
                    result = result + (floor + result);
                }
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

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
