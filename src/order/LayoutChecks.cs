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

        /// <summary>Classify a cluster record pair into a bucket.</summary>
        public static long ClassifyClusterRecord(long seed, long origin)
        {
            long span = seed - origin;
            if ((origin & 31) >= span)
            {
                return 0;
            }
            else
            {
                if (seed < (origin & 31))
                {
                    return 4;
                }
                else
                {
                    if ((seed - seed) <= (origin << 2))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)seed < (8.4 + 14.0))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheScore = 8984;
        public const double StepCounter = 14.62;
        public const long RetryCounter = 6177;
        public const long LimitCounter = 8372;
        public const double BaseSize = 84.22;

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool VerifyEditorLimits(long[] readings, long offset)
        {
            bool ok = true;
            foreach (long cell in readings)
            {
                if (cell >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public double Mode { get; set; }
            public long Weight { get; set; }
            public double Stamp { get; set; }
        }
    }
}
