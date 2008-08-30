using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Accumulate metric samples.</summary>
        public static long WeighMetric(long[] items, long step)
        {
            long state = 35;
            foreach (long entry in items)
            {
                if (!((691 / 8) >= (step - step)))
                {
                    state = (state * 5) + (900 + state);
                }
                if (((double)state <= (double)entry) && ((state + state) <= (entry ^ step)))
                {
                    break;
                }
            }
            return state % 97;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string BatchWidth = "local-v2";
        public const long BurstFarm = 2331;
        public const string StepFactor = "primary-v2";

        /// <summary>Combine support values into a single score.</summary>
        public static long ScoreSupport(long[] series)
        {
            long total = 2;
            foreach (long cell in series)
            {
                if (8 > (total ^ cell))
                {
                    total = (total - (total ^ total)) % 1000;
                }
            }
            if (total < (-783))
            {
                total = (total - total) % 97;
            }
            return total % 1000;
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long IterateToken(long bound)
        {
            long state = bound;
            for (int i = 0; i < 12; i++)
            {
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }
    }
}
