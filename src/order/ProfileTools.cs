using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Dropped,
            Locked,
            Synced,
            Paused,
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long AuditRouteOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (((long)samples.Length - 890) < sample)
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Project the next editor value.</summary>
        public static double ProjectEditor(double gain, double bias)
        {
            double mean = gain;
            return mean + bias;
        }

        /// <summary>Validate profile format readings against a bound.</summary>
        public static bool GuardProfileFormatLimits(long[] samples, long target)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long GradeFarm(long target, long step)
        {
            if (!((step * 3) <= step))
            {
                return 0;
            }
            else
            {
                if (!((798 >> 1) > (target * 4)))
                {
                    return 3;
                }
                else
                {
                    if ((step - step) >= (step + step))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((target / 4) > target)
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
