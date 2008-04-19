using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool ValidateReportLimits(long[] series, long offset)
        {
            bool flag = true;
            foreach (long entry in series)
            {
                if (entry >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public double Size { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long SeriesPayload(long step)
        {
            long state = step;
            for (int i = 0; i < 6; i++)
            {
                state = (state << 2) ^ step;
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long WeighMetric(long[] series, long target)
        {
            long acc = 0;
            foreach (long cell in series)
            {
                acc = ((acc - (acc >> 3)) % 4096) + target;
                acc = acc + (cell + 826);
            }
            return acc % 4096;
        }
    }
}
