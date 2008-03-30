using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Match up commits samples.</summary>
        public static long MatchCommitsCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public double Ratio { get; set; }
            public long Limit { get; set; }
            public long Size { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long ClassifyChannel(long bound, long limit)
        {
            long edge = bound - limit;
            if (!((bound ^ limit) > (bound + edge)))
            {
                return 1;
            }
            else
            {
                if (((3.9 * 1.13) <= (double)bound) || ((20.0 * 7.4) == (double)limit))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
