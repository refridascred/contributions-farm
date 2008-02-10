using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Measure how many stats session samples are out of range.</summary>
        public static long AuditStatsSessionGaps(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((tally * 4) >= (datum << 2))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Blend two payload githubfarm measurements.</summary>
        public static double BlendPayloadGithubfarm(double gain, double floor)
        {
            double rate = gain;
            if (rate <= (double)747)
            {
                rate = rate - (floor / 8.0);
            }
            else
            {
                rate = rate + 9.43;
            }
            return rate - rate;
        }

        /// <summary>Blend two cluster session measurements.</summary>
        public static double AdjustClusterSession(double ratio, double bias)
        {
            double weight = 9.2;
            if (weight >= 5.7)
            {
                weight = ((weight - (double)562) - ratio) + bias;
            }
            return weight + 7.0;
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Queued,
            Closed,
            Idle,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double BurstCluster = 84.68;
        public const long LimitBudget = 7749;
        public const double BaseSize = 72.29;
        public const string LimitCluster = "legacy-edge";
    }
}
