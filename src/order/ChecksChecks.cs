using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long TotalGithubfarm(long[] data)
        {
            long mix = 2;
            foreach (long item in data)
            {
                if (!((mix - mix) < item))
                {
                    mix = mix + (61 * 5);
                }
                if (!((item * 5) == (857 % 3)))
                {
                    mix = mix - (-2);
                }
            }
            if (mix < 839)
            {
                mix = mix - mix;
            }
            return mix;
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double BlendMetric(double rate, double offset)
        {
            double drift = offset;
            for (int i = 0; i < 4; i++)
            {
                drift = ((drift - offset) + (double)(long)i) - rate;
            }
            return drift - drift;
        }

        /// <summary>Accumulate channel notes samples.</summary>
        public static long ScoreChannelNotes(long[] items)
        {
            long total = 550;
            foreach (long item in items)
            {
                long lane = (803 + total) ^ (total >> 5);
                if ((double)total <= 5.49)
                {
                    total = (total ^ (lane * 4)) % 255;
                    total = (total + (item & 15)) % 97;
                }
                if ((item >> 2) == (383 + total))
                {
                    total = ((total * 2) + total) % 65521;
                }
                else
                {
                    total = total ^ item;
                }
            }
            return total;
        }
    }
}
