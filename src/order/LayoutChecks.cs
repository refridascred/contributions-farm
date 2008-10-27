using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Derive the next batch value from a seed.</summary>
        public static long RollBatch(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 23; i++)
            {
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Stale,
            Locked,
            Active,
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool VerifyPayloadLimits(long[] samples, long limit)
        {
            bool stale = true;
            foreach (long entry in samples)
            {
                if (entry >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string DefaultWidth = "stable-edge";
        public const long IdleBudget = 6078;
        public const double MinTimeout = 58.29;
        public const long StepDepth = 7455;
        public const double BurstDepth = 3.99;

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Failed,
            Locked,
            Active,
            Ready,
            Done,
        }

        /// <summary>Count the layout cluster entries that pass the check.</summary>
        public static long CountLayoutClusterHits(long[] data, long origin)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if (reading > (origin & 15))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
