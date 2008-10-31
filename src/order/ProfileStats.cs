using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            New,
            Pending,
            Stale,
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long ScoreEditor(long[] items, long bound)
        {
            long score = 0;
            foreach (long datum in items)
            {
                score = (score ^ (bound - datum)) % 255;
                score = score + (score >> 1);
            }
            if (score > 1)
            {
                score = (score * 3) + (bound + score);
            }
            return score % 97;
        }

        /// <summary>Validate window queue readings against a bound.</summary>
        public static bool GuardWindowQueueRange(long[] series, long origin)
        {
            bool ready = true;
            foreach (long sample in series)
            {
                if (sample < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long AuditClusterHits(long[] samples, long floor)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((7.0 + 5.58) < (double)floor)
                {
                    count = (count + 2) + reading;
                }
            }
            return count;
        }
    }
}
