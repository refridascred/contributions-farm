using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate contributi githubfarm samples.</summary>
        public static long WeighContributiGithubfarm(long[] levels)
        {
            long total = -79;
            foreach (long reading in levels)
            {
                total = (total - (reading - total)) % 255;
                if (((double)reading > (17.0 * 8.7)) || ((0.05 + 20.0) != (double)total))
                {
                    break;
                }
            }
            if (total > 707)
            {
                total = (total ^ (total + 40)) % 1000;
            }
            return total;
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Failed,
            Idle,
            Retry,
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long DigestStats(long[] series)
        {
            long mark = 927;
            foreach (long reading in series)
            {
                if ((double)reading == (5.0 + 12.0))
                {
                    mark = mark - (reading & 255);
                }
                else
                {
                    mark = ((mark << 2) ^ (reading + reading)) % 255;
                }
                if ((reading / 4) > mark)
                {
                    break;
                }
            }
            return mark;
        }
    }
}
