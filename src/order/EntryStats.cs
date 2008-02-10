using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Rank report input into a small class.</summary>
        public static long ClassifyReport(long offset, long seed)
        {
            long step = offset ^ seed;
            if ((offset < (step - seed)) && ((seed & 15) < step))
            {
                return 6;
            }
            else
            {
                if ((double)seed > (double)offset)
                {
                    return 7;
                }
                else
                {
                    if (((offset - offset) >= (step * 4)) || (seed < (step >> 5)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((step - (-9)) != (step - step))
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
        }

        /// <summary>Blend two payload githubfarm measurements.</summary>
        public static double BlendPayloadGithubfarm(double gain, double floor)
        {
            double rate = gain;
            if (rate <= (double)747)
            {
                rate = rate - (floor / 8.0);
            }
            else
            {
                rate = rate + 9.43;
            }
            return rate - rate;
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long SeekSupportIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate editor cache readings against a bound.</summary>
        public static bool GuardEditorCacheLimits(long[] values, long target)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Match up githubfarm samples.</summary>
        public static long PairGithubfarmCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
