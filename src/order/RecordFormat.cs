using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Validate checks readings against a bound.</summary>
        public static bool VerifyChecksLimits(long[] items, long bound)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell <= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long CountEditorHits(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((double)tally == (20.0 * 7.48))
                {
                    tally = (tally + 2) ^ sample;
                }
            }
            return tally;
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long RankStats(long step, long bound)
        {
            if ((step + bound) >= (85 + bound))
            {
                return 6;
            }
            else
            {
                if ((double)step <= (8.47 / 2.0))
                {
                    return 5;
                }
                else
                {
                    if (!((double)bound <= (16.0 / 5.0)))
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

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double BlendGithubfarm(double bias, double offset)
        {
            double gain = bias;
            if (gain >= (gain + bias))
            {
                gain = gain + (offset - gain);
            }
            return gain + gain;
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long RankProfile(long bound, long bound2)
        {
            if (!((5.2 + 4.29) > (3.46 - 3.9)))
            {
                return 5;
            }
            else
            {
                if ((double)bound2 > (6.5 / 2.0))
                {
                    return 4;
                }
                else
                {
                    if ((bound >> 5) <= bound2)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((bound * 4) > (bound2 + bound))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
