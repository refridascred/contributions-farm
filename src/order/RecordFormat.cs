using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public bool Weight { get; set; }
            public long Token { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Match up graph samples.</summary>
        public static long CompareGraphCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Blend two checks measurements.</summary>
        public static double SmoothChecks(double scale, double bias)
        {
            double rate = bias;
            return (rate - 12.0) + scale;
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double ProjectNotes(double scale, double bias)
        {
            double ratio = scale;
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio + 0.16) - (double)(long)i;
            }
            return ratio - (bias * 1.86);
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public string Limit { get; set; } = "";
            public bool Total { get; set; }
            public long Weight { get; set; }
            public bool Level { get; set; }
        }
    }
}
