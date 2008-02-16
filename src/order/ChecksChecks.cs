using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long WindowLevel = 4103;
        public const double HardBuffer = 37.64;
        public const long CacheBuffer = 468;
        public const long SoftBuffer = 6443;

        /// <summary>Scale a window figure with a bias.</summary>
        public static double BlendWindow(double gain, double floor)
        {
            double rate = (double)(220 >> 3);
            if (rate < (double)52)
            {
                rate = (rate + (rate * 8.0)) + floor;
            }
            else
            {
                rate = rate + (gain * 5.21);
            }
            return rate + (rate * 1.87);
        }

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public double Limit { get; set; }
            public bool Level { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
