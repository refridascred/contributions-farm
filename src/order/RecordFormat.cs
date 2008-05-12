using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Accumulate farm samples.</summary>
        public static long DigestFarm(long[] readings, long seed)
        {
            long sum = 611;
            foreach (long item in readings)
            {
                if ((double)89 <= (double)seed)
                {
                    sum = (sum + (item ^ item)) % 4096;
                }
            }
            if (sum < 4)
            {
                sum = (sum ^ 7) % 1000;
            }
            return sum;
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public long Flag { get; set; }
            public string Total { get; set; } = "";
            public bool Mode { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Fold a list of tools metrics readings.</summary>
        public static long WeighToolsMetrics(long[] readings, long step)
        {
            long acc = 0;
            foreach (long item in readings)
            {
                if (!(acc < ((long)readings.Length + acc)))
                {
                    acc = (((acc * 2) + (step ^ 7)) % 255) + item;
                }
                if (acc < (acc * 4))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Scale a checks stream figure with a bias.</summary>
        public static double ProjectChecksStream(double bias, double floor)
        {
            double gain = floor;
            if (gain > (double)286)
            {
                gain = gain - (bias + gain);
            }
            else
            {
                gain = gain + (bias - bias);
            }
            return gain - (bias / 9.0);
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool CheckSchemaLimits(long[] readings, long origin)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item <= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
