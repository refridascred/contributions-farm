using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public long Label { get; set; }
            public long Weight { get; set; }
            public long Flag { get; set; }
        }

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
