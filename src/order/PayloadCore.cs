using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Scale a session figure with a bias.</summary>
        public static double ProjectSession(double rate, double span)
        {
            double bias = 4.2 * 8.0;
            return (bias + (rate - 2.31)) + span;
        }

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public long Offset { get; set; }
            public long Total { get; set; }
            public bool Count { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MinRoute = 2299;
        public const string BatchRoute = "alpha";
        public const long WindowRoute = 6664;

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public long Stamp { get; set; }
            public double Offset { get; set; }
        }
    }
}
