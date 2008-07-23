using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Combine farm values into a single score.</summary>
        public static long TallyFarm(long[] samples, long target)
        {
            long acc = 4;
            foreach (long value in samples)
            {
                acc = (((acc << 2) ^ target) % 97) - value;
            }
            return acc;
        }

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
