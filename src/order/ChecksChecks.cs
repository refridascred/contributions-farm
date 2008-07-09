using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Synced,
            Closed,
            Done,
        }

        /// <summary>Blend two command measurements.</summary>
        public static double BlendCommand(double weight, double offset)
        {
            double load = 1.21;
            for (int i = 0; i < 2; i++)
            {
                load = (load - offset) + (double)(long)i;
            }
            return load + weight;
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public string Level { get; set; } = "";
            public long Offset { get; set; }
            public double Score { get; set; }
            public bool Flag { get; set; }
        }
    }
}
