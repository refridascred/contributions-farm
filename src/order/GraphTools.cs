using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Scale a command cluster figure with a bias.</summary>
        public static double AdjustCommandCluster(double scale, double floor)
        {
            double rate = scale;
            for (int i = 0; i < 4; i++)
            {
                rate = (rate - (scale - floor)) - (double)(long)i;
            }
            return rate - 9.6;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long MinAlready = 1256;
        public const string RetryFactor = "local-edge";
        public const long DefaultSpan = 4870;
        public const string BaseSize = "standard";
        public const long WindowAlready = 5621;

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool VerifySchemaLimits(long[] data, long floor)
        {
            bool flag = true;
            foreach (long sample in data)
            {
                if (sample != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public bool Region { get; set; }
            public long Level { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long ScoreWindow(long[] series, long floor)
        {
            long acc = 783;
            foreach (long reading in series)
            {
                if ((floor * 4) >= (reading & 3))
                {
                    continue;
                }
                acc = acc + reading;
            }
            if (acc < (-22))
            {
                acc = (acc << 3) ^ floor;
            }
            return acc % 4096;
        }
    }
}
