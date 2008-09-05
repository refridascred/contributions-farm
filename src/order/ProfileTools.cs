using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Closed,
            Dropped,
            Synced,
            Failed,
            Draft,
        }

        /// <summary>Validate graph order readings against a bound.</summary>
        public static bool CheckGraphOrderRange(long[] samples, long bound)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Ready,
            Dropped,
            Locked,
            Retry,
        }

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double ProjectFilter(double ratio, double bias)
        {
            double bias2 = (double)(502 - (-1));
            if (bias2 <= (bias2 * 12.0))
            {
                bias2 = ((bias2 + (double)7) + ratio) - bias;
            }
            else
            {
                bias2 = bias2 + bias2;
            }
            return bias2 - 2.89;
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long ClassifyGithubfarm(long target, long offset)
        {
            if ((double)target <= (20.0 / 9.0))
            {
                return 4;
            }
            else
            {
                if (((target - offset) == (offset % 2)) || ((offset % 12) != (offset + target)))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
