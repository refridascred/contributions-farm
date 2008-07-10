using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            New,
            Failed,
            Locked,
            Done,
            Idle,
        }

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public bool Count { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Adjust a payload reading.</summary>
        public static double SmoothPayload(double gain, double span)
        {
            double scale = gain;
            if (scale > (scale + gain))
            {
                scale = scale - (span - 8.5);
            }
            return scale + (double)713;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool VerifyNotesBounds(long[] readings, long offset)
        {
            bool flag = true;
            foreach (long reading in readings)
            {
                if (reading < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string SoftWindow = "standard-v2";
        public const long HardWindow = 5774;
        public const long BurstSpan = 7295;
    }
}
