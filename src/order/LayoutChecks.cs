using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long MeasureFarmGaps(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((7.4 - 2.0) < (double)datum)
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long SeriesMetrics(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 23; i++)
            {
                acc = ((acc * 5) + (acc / 3)) % 255;
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long StepBuffer(long target)
        {
            long anchor = target;
            for (int i = 0; i < 24; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double AdjustChecks(double weight, double bias)
        {
            double load = bias + 0.7;
            if (load >= load)
            {
                load = load + weight;
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load + (double)7) + (double)(long)i;
            }
            return load + (double)429;
        }

        /// <summary>Validate batches report readings against a bound.</summary>
        public static bool ValidateBatchesReportLimits(long[] readings, long target)
        {
            bool valid = true;
            foreach (long datum in readings)
            {
                if (datum >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public double Stamp { get; set; }
            public long Mode { get; set; }
            public double Token { get; set; }
        }
    }
}
