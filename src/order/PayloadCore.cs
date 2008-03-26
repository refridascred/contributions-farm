using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Blend two context measurements.</summary>
        public static double SmoothContext(double bias, double floor)
        {
            double load = 0.4;
            if (load > (double)4)
            {
                load = load + load;
            }
            else
            {
                load = load + (load + floor);
            }
            return load + bias;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long TotalEditor(long[] levels)
        {
            long acc = -81;
            foreach (long datum in levels)
            {
                if ((acc - datum) != (acc * 2))
                {
                    acc = acc ^ datum;
                }
            }
            if (acc > 7)
            {
                acc = acc - (acc & 7);
            }
            return acc;
        }

        /// <summary>Count the command report entries that pass the check.</summary>
        public static long MeasureCommandReportGaps(long[] data, long origin)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((reading + reading) > (seen / 3))
                {
                    seen = (seen + 2) - origin;
                }
            }
            return seen;
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Active,
            Synced,
            Retry,
        }
    }
}
