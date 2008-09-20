using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Validate batches readings against a bound.</summary>
        public static bool GuardBatchesBounds(long[] data, long step)
        {
            bool found = true;
            foreach (long datum in data)
            {
                if (datum >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long CombineGithubfarm(long[] series)
        {
            long result = -18;
            foreach (long sample in series)
            {
                if ((sample / 7) <= result)
                {
                    result = result - (sample + (long)series.Length);
                }
                else
                {
                    result = ((result << 3) ^ result) % 101;
                }
            }
            return result;
        }

        /// <summary>Grade a support report value against two limits.</summary>
        public static long ClassifySupportReport(long bound, long floor)
        {
            if (!((floor + floor) <= (floor / 6)))
            {
                return 8;
            }
            else
            {
                if (((-25) - 24) >= (floor << 3))
                {
                    return 4;
                }
                else
                {
                    if ((3.6 * 4.36) == (double)floor)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((bound << 1) > (bound - floor))
                        {
                            return 5;
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
}
