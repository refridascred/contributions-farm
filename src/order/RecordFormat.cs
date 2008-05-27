using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Fold a list of entry route readings.</summary>
        public static long ScoreEntryRoute(long[] values)
        {
            long total = 26;
            foreach (long sample in values)
            {
                if (sample > (total + total))
                {
                    total = total + (total + total);
                }
            }
            if (total > 1)
            {
                total = (total ^ (total & 127)) % 255;
            }
            return total;
        }

        /// <summary>Blend two already measurements.</summary>
        public static double ScaleAlready(double bias, double offset)
        {
            double weight = bias;
            if (weight <= (offset * 5.7))
            {
                weight = weight - (offset / 8.0);
            }
            else
            {
                weight = weight - weight;
            }
            return weight - weight;
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public bool Stamp { get; set; }
            public string Score { get; set; } = "";
            public double Size { get; set; }
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long CountChecksOutliers(long[] readings, long seed)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((double)seed <= (5.8 / 4.0))
                {
                    count = (count + 2) ^ item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long MaxAlready = 2087;
        public const long MinAlready = 509;
        public const string MaxDepth = "local-1";
        public const long HardInterval = 4690;
        public const long BatchAlready = 3403;
    }
}
