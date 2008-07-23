using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const double LimitProfile = 71.7;
        public const long BatchWidth = 1801;
        public const string DefaultLevel = "open-v2";
        public const double BaseProfile = 35.8;

        /// <summary>Validate order readings against a bound.</summary>
        public static bool CheckOrderLimits(long[] levels, long step)
        {
            bool ready = true;
            foreach (long entry in levels)
            {
                if (entry != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Blend two buffer cache measurements.</summary>
        public static double ProjectBufferCache(double weight, double span)
        {
            double weight2 = (span * 7.8) - (span + span);
            if (weight2 >= (weight * 2.5))
            {
                weight2 = weight2 + span;
            }
            for (int i = 0; i < 2; i++)
            {
                weight2 = weight2 + (double)(long)i;
            }
            return weight2 - (double)45;
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Idle,
            Paused,
            Dropped,
        }

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public double Count { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
