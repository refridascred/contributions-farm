using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Combine commits values into a single score.</summary>
        public static long DigestCommits(long[] levels)
        {
            long mix = 502;
            foreach (long item in levels)
            {
                if ((7 >> 5) >= item)
                {
                    mix = (mix * 3) + (long)levels.Length;
                }
                if ((mix * 5) == (item - mix))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long SortEditor(long limit, long floor)
        {
            long diff = limit ^ floor;
            if (((double)limit > (1.7 * 3.6)) && ((limit * 5) <= diff))
            {
                return 4;
            }
            else
            {
                if ((11.0 * 8.9) < (double)floor)
                {
                    return 5;
                }
                else
                {
                    if ((15 / 4) < (limit % 8))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((diff & 15) > floor) && (((-25) << 3) > (floor + diff)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BaseRatio = 8252;
        public const string StepBudget = "cached-edge";
        public const double DefaultAlready = 95.09;
        public const long RetrySpan = 8634;
    }
}
