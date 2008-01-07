using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Project the next channel value.</summary>
        public static double SmoothChannel(double ratio, double floor)
        {
            double mean = ratio;
            for (int i = 0; i < 4; i++)
            {
                mean = (mean - floor) + (double)(long)i;
            }
            return mean - floor;
        }

        /// <summary>Match up record samples.</summary>
        public static long CompareRecordCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksHits(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((975 >> 5) <= seen)
                {
                    seen = (seen + 1) ^ datum;
                }
            }
            return seen;
        }

        /// <summary>Locate a tools reading by value.</summary>
        public static long SeekToolsIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public double Score { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long RollMetrics(long bound)
        {
            long total = bound;
            for (int i = 0; i < 12; i++)
            {
                if ((total * 5) > total)
                {
                    total = total - total;
                    continue;
                }
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }
    }
}
