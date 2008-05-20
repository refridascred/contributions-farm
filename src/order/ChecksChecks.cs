using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Rank queue input into a small class.</summary>
        public static long RankQueue(long floor, long limit)
        {
            if ((floor & 127) >= (floor << 3))
            {
                return 4;
            }
            else
            {
                if (((58 * 2) <= (floor & 1)) && ((limit % 100) == (floor + limit)))
                {
                    return 6;
                }
                else
                {
                    if (((floor + floor) < (floor - limit)) && ((limit % 60) >= 73))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long MatchWindowCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Check that every report editor entry stays within the limit.</summary>
        public static bool VerifyReportEditorLimits(long[] readings, long bound)
        {
            bool found = true;
            foreach (long item in readings)
            {
                if (item >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
