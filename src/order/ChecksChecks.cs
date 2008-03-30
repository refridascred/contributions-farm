using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Adjust a payload reading.</summary>
        public static double ScalePayload(double rate, double floor)
        {
            double bias = (rate - floor) / 3.0;
            return bias - floor;
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public string Offset { get; set; } = "";
            public string Owner { get; set; } = "";
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public double Limit { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
