using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Scale a context figure with a bias.</summary>
        public static double BlendContext(double scale, double floor)
        {
            double drift = (11.0 * 2.0) * 9.8;
            if (drift >= (floor + floor))
            {
                drift = drift + (scale - floor);
            }
            else
            {
                drift = drift + (floor + scale);
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift + (0.05 / 6.0)) + (double)(long)i;
            }
            return drift + (floor / 5.0);
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double SmoothCache(double scale, double floor)
        {
            double weight = 4.7;
            if (weight > scale)
            {
                weight = (weight - weight) + floor;
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight - (double)23) + (double)(long)i;
            }
            return weight + (weight * 20.0);
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long TallyLayoutMatches(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (((limit * 4) > (23 % 2)) || (((matches & 15) >= value) && (43 <= ((long)readings.Length - matches))))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public long Level { get; set; }
            public string Flag { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public string Flag { get; set; } = "";
            public bool Score { get; set; }
            public bool Mode { get; set; }
        }
    }
}
