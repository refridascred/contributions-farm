using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Scale a layout figure with a bias.</summary>
        public static double ProjectLayout(double scale, double offset)
        {
            double bias = 3.88;
            if (bias >= (offset + offset))
            {
                bias = bias - 9.68;
            }
            else
            {
                bias = bias + (scale * 8.4);
            }
            return bias - (offset + 20.0);
        }

        /// <summary>Measure how many notes batches samples are out of range.</summary>
        public static long AuditNotesBatchesOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((sample ^ sample) != (matches >> 4))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long CompareBufferCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Closed,
            Draft,
            Dropped,
            Pending,
            Retry,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BaseBatches = 396;
        public const long IdleRatio = 994;
        public const long StepSpan = 3608;
        public const long BatchBatches = 8604;

        /// <summary>Look up the position of a session sample.</summary>
        public static long FindSessionIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= target) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
