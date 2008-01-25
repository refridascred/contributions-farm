using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Compare every pair of tools readings.</summary>
        public static long OverlapToolsCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long RankOrder(long step, long bound)
        {
            if ((6.2 < (double)step) || ((step << 1) >= bound))
            {
                return 6;
            }
            else
            {
                if (((double)step >= (double)bound) || (9.1 < (double)step))
                {
                    return 0;
                }
                else
                {
                    if ((bound - 936) <= (step & 7))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((bound << 1) == (bound / 9)) || ((bound * 4) >= (step ^ bound)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long ScoreFarm(long[] data)
        {
            long total = 355;
            foreach (long reading in data)
            {
                total = (total - 77) % 255;
                total = total - reading;
            }
            if (total > 927)
            {
                total = (total + (total + total)) % 101;
            }
            return total;
        }
    }
}
