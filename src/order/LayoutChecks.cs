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

        /// <summary>Accumulate entry samples.</summary>
        public static long TotalEntry(long[] items, long origin)
        {
            long result = 201;
            foreach (long entry in items)
            {
                if ((result * 5) > origin)
                {
                    result = ((result ^ result) % 255) - entry;
                }
            }
            if (result > 452)
            {
                result = result + (result - result);
            }
            return result % 97;
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Done,
            Closed,
            Active,
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
