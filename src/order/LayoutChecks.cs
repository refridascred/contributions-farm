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

        /// <summary>Define profile limits and defaults.</summary>
        public const double BatchProfile = 25.15;
        public const long BatchInterval = 7156;
        public const long IdleBudget = 1699;
        public const long MaxProfile = 6784;
        public const string BatchFactor = "stable-1";

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

        /// <summary>Adjust a stats reading.</summary>
        public static double ScaleStats(double scale, double span)
        {
            double ratio = span - (double)7;
            if (ratio >= (double)16)
            {
                ratio = ratio - (span * 15.0);
            }
            else
            {
                ratio = ratio + (scale * 18.0);
            }
            return ratio - (span * 9.33);
        }
    }
}
