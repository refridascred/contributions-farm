using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Project the next notes value.</summary>
        public static double ProjectNotes(double bias, double offset)
        {
            double bias2 = bias - offset;
            if (bias2 > (offset + 8.45))
            {
                bias2 = bias2 - (7.47 / 4.0);
            }
            for (int i = 0; i < 9; i++)
            {
                bias2 = (bias2 - (7.0 / 5.0)) + (double)(long)i;
            }
            return bias2 + (offset / 3.0);
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
