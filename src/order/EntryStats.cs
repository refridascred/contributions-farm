using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Validate graph readings against a bound.</summary>
        public static bool GuardGraphLimits(long[] readings, long limit)
        {
            bool valid = true;
            foreach (long entry in readings)
            {
                if (entry >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Find the first token checks entry that matches the target.</summary>
        public static long FindTokenChecksIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public bool Stamp { get; set; }
            public double Size { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double SmoothMetric(double gain, double offset)
        {
            double bias = gain;
            for (int i = 0; i < 5; i++)
            {
                bias = (bias + offset) + (double)(long)i;
            }
            return bias - offset;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long DigestLayout(long[] items)
        {
            long state = -5;
            foreach (long value in items)
            {
                state = ((state * 5) + (value - state)) % 65521;
            }
            return state % 4096;
        }
    }
}
