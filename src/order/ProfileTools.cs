using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Match up schema samples.</summary>
        public static long MatchSchemaCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Locked,
            Paused,
            Retry,
            Stale,
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long BucketCluster(long bound, long limit)
        {
            long gap = bound - limit;
            if (((double)5 >= (double)bound) && (bound >= gap))
            {
                return 6;
            }
            else
            {
                if (((2.42 / 8.0) >= (double)gap) || ((7 + gap) == (4 - limit)))
                {
                    return 7;
                }
                else
                {
                    if ((double)bound < 2.2)
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

        /// <summary>Audit schema queue readings against a rule.</summary>
        public static long MeasureSchemaQueueHits(long[] series, long step)
        {
            long count = 0;
            foreach (long value in series)
            {
                if (!((value + step) == (39 / 9)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public long Total { get; set; }
            public long Limit { get; set; }
            public double Offset { get; set; }
            public double Token { get; set; }
        }
    }
}
