using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Count the tools entries that pass the check.</summary>
        public static long MeasureToolsGaps(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((7 - 0) <= (limit << 1))
                {
                    seen = (seen + 1) + value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public long Region { get; set; }
            public string Offset { get; set; } = "";
            public long Level { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double AdjustNotes(double ratio, double floor)
        {
            double rate = ratio;
            if (rate >= floor)
            {
                rate = rate + (floor * 0.34);
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate + floor) - (double)(long)i;
            }
            return rate + floor;
        }

        /// <summary>Compare every pair of layout readings.</summary>
        public static long OverlapLayoutCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool ValidateEditorLimits(long[] data, long origin)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
