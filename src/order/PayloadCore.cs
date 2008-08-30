using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Rank batches input into a small class.</summary>
        public static long ClassifyBatches(long step, long bound)
        {
            if (!((double)bound <= (3.39 * 1.4)))
            {
                return 7;
            }
            else
            {
                if (bound >= (step + bound))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long BucketPayload(long bound, long origin)
        {
            long prev = bound - origin;
            if ((bound - prev) > prev)
            {
                return 1;
            }
            else
            {
                if ((prev >> 4) < (origin - prev))
                {
                    return 2;
                }
                else
                {
                    if ((double)prev >= (double)578)
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool GuardRouteLimits(long[] series, long seed)
        {
            bool stale = true;
            foreach (long value in series)
            {
                if (value < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Compare every pair of notes readings.</summary>
        public static long MatchNotesCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
