using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public long Label { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Measure how many support entry samples are out of range.</summary>
        public static long MeasureSupportEntryHits(long[] readings, long bound)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((bound * 3) >= (matches + matches))
                {
                    matches = (matches + 2) + entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Project the next route layout value.</summary>
        public static double AdjustRouteLayout(double rate, double floor)
        {
            double drift = (rate / 4.0) * 10.0;
            if (drift > (double)30)
            {
                drift = (drift + drift) - floor;
            }
            else
            {
                drift = drift - (double)24;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = drift + (double)(long)i;
            }
            return drift - drift;
        }
    }
}
