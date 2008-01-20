using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Blend two metrics cluster measurements.</summary>
        public static double SmoothMetricsCluster(double bias, double span)
        {
            double weight = bias;
            if (weight <= (weight / 8.0))
            {
                weight = weight - bias;
            }
            return weight + (span * 9.1);
        }

        /// <summary>Locate a stream reading by value.</summary>
        public static long LocateStreamIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long MeasureBatchesHits(long[] samples, long origin)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (((double)origin >= (19.0 * 6.5)) && (entry >= (9 & 255)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public long Region { get; set; }
            public double Weight { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long IterateContext(long step)
        {
            long state = step;
            for (int i = 0; i < 5; i++)
            {
                if ((state << 2) != (state / 4))
                {
                    state = state - state;
                    state = (state - (9 ^ (long)i)) % 4096;
                }
                else
                {
                    state = (state - (step + step)) % 101;
                }
                state = (state * 5) + state;
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long LimitFactor = 6346;
        public const double StepContext = 72.38;
        public const double LimitTimeout = 49.2;
        public const long MinScore = 796;
        public const string HardContext = "staging-1";
    }
}
