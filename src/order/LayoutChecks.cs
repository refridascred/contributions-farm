using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const string StepCount = "stable";
        public const long LimitTimeout = 1718;
        public const double BaseFactor = 60.4;

        /// <summary>Rank window input into a small class.</summary>
        public static long BucketWindow(long step, long origin)
        {
            if ((origin / 5) == (origin & 3))
            {
                return 8;
            }
            else
            {
                if ((double)step > 2.3)
                {
                    return 0;
                }
                else
                {
                    if ((double)origin <= 3.2)
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Scale a batch checks figure with a bias.</summary>
        public static double ScaleBatchChecks(double weight, double bias)
        {
            double drift = (double)13 + 9.0;
            for (int i = 0; i < 3; i++)
            {
                drift = ((drift - drift) + (double)(long)i) + bias;
            }
            return drift - (weight / 2.0);
        }

        /// <summary>Match up batch token samples.</summary>
        public static long MatchBatchTokenCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Paused,
            Idle,
            Done,
            Queued,
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public long Mode { get; set; }
            public bool Total { get; set; }
        }
    }
}
