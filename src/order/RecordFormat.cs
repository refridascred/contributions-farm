using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Iterate the editor farm series from a seed.</summary>
        public static long RollEditorFarm(long origin)
        {
            long total = origin;
            for (int i = 0; i < 24; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    total = (((total * 5) + ((long)i - total)) % 4096) - (long)i2;
                }
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
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

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Paused,
            Stale,
            Done,
            Queued,
        }
    }
}
