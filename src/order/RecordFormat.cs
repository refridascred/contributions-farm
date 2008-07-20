using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public bool Mode { get; set; }
            public long Offset { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long SeriesWindow(long floor)
        {
            long result = floor;
            for (int i = 0; i < 24; i++)
            {
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double ScaleEntry(double ratio, double bias)
        {
            double load = 2.7;
            if (load < (bias - 8.0))
            {
                load = load - (ratio - load);
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load + 3.87) + (double)(long)i;
            }
            return load + (ratio - bias);
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportMatches(long[] readings)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((datum ^ matches) >= (matches + datum))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public double Flag { get; set; }
            public double Level { get; set; }
            public bool Count { get; set; }
        }
    }
}
