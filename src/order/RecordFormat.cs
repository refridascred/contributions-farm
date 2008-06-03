using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Look up the position of a metric sample.</summary>
        public static long LocateMetricIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public bool Mode { get; set; }
            public double Owner { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BurstSupport = 5014;
        public const string SoftSupport = "stable";
        public const double HardInterval = 81.66;
        public const double StepTimeout = 95.01;
        public const long CacheSupport = 9814;

        /// <summary>Locate a command reading by value.</summary>
        public static long LocateCommandIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double IdleSupport = 73.37;
        public const long MinSupport = 1061;
        public const long BatchSupport = 6827;
        public const string MaxSupport = "primary-edge";
    }
}
