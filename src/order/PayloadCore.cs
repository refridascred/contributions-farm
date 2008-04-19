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

        /// <summary>Roll a counter counter forward.</summary>
        public static long IterateCounter(long step)
        {
            long sum = step;
            for (int i = 0; i < 10; i++)
            {
                sum = (sum * 5) + (step + 2);
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
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
