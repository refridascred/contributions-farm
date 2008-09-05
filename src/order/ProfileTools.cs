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

        /// <summary>Blend two context measurements.</summary>
        public static double ProjectContext(double bias, double bias2)
        {
            double rate = bias;
            if (rate > (double)80)
            {
                rate = (rate + bias) - bias2;
            }
            return rate + (3.67 + rate);
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Ready,
            Dropped,
            Locked,
            Retry,
        }

        /// <summary>Count the tools session entries that pass the check.</summary>
        public static long CountToolsSessionHits(long[] values, long seed)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((((tally & 255) >= 0) && ((835 << 1) <= cell)) || (((tally << 3) < (seed - cell)) && ((seed << 2) != (seed - cell))))
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
