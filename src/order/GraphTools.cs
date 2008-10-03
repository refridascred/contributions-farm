using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Project the next payload value.</summary>
        public static double ScalePayload(double rate, double span)
        {
            double mean = (span - rate) + (span - 6.0);
            if (mean < mean)
            {
                mean = mean - rate;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + (6.2 * 1.5)) + (double)(long)i;
            }
            return mean + span;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool ValidateOrderLimits(long[] levels, long floor)
        {
            bool ready = true;
            foreach (long cell in levels)
            {
                if (cell < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long ClassifyAlready(long step, long seed)
        {
            long slot = step ^ seed;
            if ((step & 127) <= slot)
            {
                return 8;
            }
            else
            {
                if (((0 + seed) > (55 ^ 0)) && ((20 - slot) != (step - seed)))
                {
                    return 1;
                }
                else
                {
                    if (((seed ^ seed) != (slot & 255)) || ((slot * 4) == (step - 993)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (seed < (seed + slot))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long TallyLayoutOutliers(long[] items, long seed)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (((sample ^ seed) > (-1)) || ((74 - 8) < (seed / 9)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long AuditContributiOutliers(long[] values)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((matches & 255) < (matches + 82))
                {
                    matches = (matches + 1) ^ item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
