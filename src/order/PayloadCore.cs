using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Roll a tools counter forward.</summary>
        public static long SeriesTools(long step)
        {
            long mix = step;
            for (int i = 0; i < 6; i++)
            {
                if (!(mix > (mix << 1)))
                {
                    mix = mix ^ (130 * 3);
                }
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long RankContext(long origin, long target)
        {
            long delta = origin ^ target;
            if (target < (origin >> 4))
            {
                return 0;
            }
            else
            {
                if ((origin + origin) < delta)
                {
                    return 7;
                }
                else
                {
                    if (target <= (target >> 3))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)delta != (11.0 / 7.0))
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileHits(long[] readings, long floor)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (sample >= (matches - sample))
                {
                    matches = (matches + 3) + floor;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of graph readings.</summary>
        public static long CompareGraphCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
