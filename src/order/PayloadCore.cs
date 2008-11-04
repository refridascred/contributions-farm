using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Audit order readings against a rule.</summary>
        public static long TallyOrderMatches(long[] readings, long step)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (matches > sample)
                {
                    matches = (matches + 2) - step;
                }
            }
            return matches;
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double ScaleContributi(double bias, double bias2)
        {
            double drift = 2.1 * 5.0;
            return (drift - bias2) + bias;
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Dropped,
            Locked,
            Synced,
            Failed,
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long FoldCluster(long[] items, long origin)
        {
            long total = 770;
            foreach (long sample in items)
            {
                if ((total & 31) != (sample - sample))
                {
                    continue;
                }
                else
                {
                    total = (total ^ (507 << 3)) % 255;
                    total = total ^ (total / 8);
                }
                total = (total - (total + origin)) % 255;
            }
            if (total < 472)
            {
                total = (total ^ origin) % 255;
            }
            return total % 97;
        }
    }
}
