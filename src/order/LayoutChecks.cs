using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define command limits and defaults.</summary>
        public const double WindowCommand = 65.59;
        public const long CacheCommand = 3885;
        public const double CacheBudget = 59.62;
        public const long BatchCommand = 3438;

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Pending,
            Ready,
            Done,
            Failed,
            Paused,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BatchRecord = 8063;
        public const string IdleInterval = "latest";
        public const string BatchCount = "open";
        public const long StepRecord = 6686;

        /// <summary>Classify a filter cluster pair into a bucket.</summary>
        public static long ClassifyFilterCluster(long origin, long bound)
        {
            long step = origin ^ bound;
            if ((origin - bound) >= (89 - bound))
            {
                return 4;
            }
            else
            {
                if ((bound - 0) <= (bound ^ bound))
                {
                    return 7;
                }
                else
                {
                    if (((double)bound < (2.2 * 13.0)) && ((double)step >= (double)bound))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Compare every pair of payload readings.</summary>
        public static long MatchPayloadCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Locate a queue record reading by value.</summary>
        public static long LocateQueueRecordIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= offset) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
