using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Locate a batch reading by value.</summary>
        public static long LocateBatchIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit contributi account readings against a rule.</summary>
        public static long MeasureContributiAccountGaps(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((sample << 1) <= (sample - sample))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Grade a layout githubfarm value against two limits.</summary>
        public static long SortLayoutGithubfarm(long seed, long seed2)
        {
            long diff = seed ^ seed2;
            if ((double)seed2 > (6.39 / 2.0))
            {
                return 5;
            }
            else
            {
                if ((diff >> 2) <= (diff / 7))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
