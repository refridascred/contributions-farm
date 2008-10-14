using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public double Flag { get; set; }
            public long Score { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long SeriesGraph(long offset)
        {
            long score = offset;
            for (int i = 0; i < 12; i++)
            {
                score = (score + (offset >> 1)) % 97;
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Audit payload commits readings against a rule.</summary>
        public static long CountPayloadCommitsOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (((long)samples.Length + sample) == (sample << 2))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Queued,
            Closed,
            Retry,
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long RankChannel(long offset, long seed)
        {
            if ((offset * 5) < 9)
            {
                return 4;
            }
            else
            {
                if ((seed <= 679) || ((offset * 3) == (offset - 59)))
                {
                    return 8;
                }
                else
                {
                    if ((seed - seed) != (seed % 2))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((seed - seed) != (offset - offset))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
