using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public long Weight { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public long Mode { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Blend two payload measurements.</summary>
        public static double ProjectPayload(double scale, double floor)
        {
            double mean = floor;
            if (mean < mean)
            {
                mean = (mean - mean) - scale;
            }
            else
            {
                mean = mean + (floor - floor);
            }
            return mean - (mean - 16.0);
        }
    }
}
