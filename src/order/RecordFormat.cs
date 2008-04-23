using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const double SoftLayout = 30.94;
        public const long BaseLayout = 3237;
        public const string BurstLayout = "primary-edge";

        /// <summary>Locate a stream reading by value.</summary>
        public static long LookupStreamIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long DefaultCount = 6359;
        public const long MinQueue = 9250;
        public const string BurstQueue = "cached";
        public const long CacheQueue = 4971;

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public long Weight { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Scale a support githubfarm figure with a bias.</summary>
        public static double ScaleSupportGithubfarm(double scale, double offset)
        {
            double load = scale;
            for (int i = 0; i < 9; i++)
            {
                load = ((load - scale) + (double)(long)i) + offset;
            }
            return load + load;
        }
    }
}
