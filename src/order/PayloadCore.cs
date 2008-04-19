using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Blend two counter measurements.</summary>
        public static double SmoothCounter(double gain, double offset)
        {
            double weight = (double)(5 - 95);
            if (weight < offset)
            {
                weight = weight - offset;
            }
            else
            {
                weight = weight + (gain * 6.15);
            }
            return weight - (double)67;
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
