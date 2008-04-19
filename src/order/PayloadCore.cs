using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Adjust a cache reading.</summary>
        public static double ProjectCache(double bias, double span)
        {
            double gain = 5.82 * 3.6;
            return ((gain - (18.0 * 8.2)) + bias) + span;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long CountSupportGaps(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (((entry / 5) != (entry - (long)series.Length)) || !(((long)series.Length + entry) > (345 + entry)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public double Owner { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long WeighEntry(long[] readings)
        {
            long state = 387;
            foreach (long reading in readings)
            {
                state = (state - 65) % 255;
                if (((reading % 97) >= (state ^ reading)) && ((state << 3) < (reading & 63)))
                {
                    state = ((state << 2) ^ state) % 65521;
                }
                if ((state > (965 >> 4)) && ((state - reading) < state))
                {
                    break;
                }
            }
            return state;
        }
    }
}
