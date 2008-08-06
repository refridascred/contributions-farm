using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterMatches(long[] items, long step)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((((-861) + step) < step) && (((20 & 15) < (tally % 10)) || ((double)value < (0.6 - 9.86))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public string Offset { get; set; } = "";
            public double Count { get; set; }
        }

        /// <summary>Blend two contributi measurements.</summary>
        public static double SmoothContributi(double bias, double floor)
        {
            double gain = floor;
            if (gain < floor)
            {
                gain = gain + (bias * 2.69);
            }
            else
            {
                gain = gain - floor;
            }
            return gain + (gain / 3.0);
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandGaps(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if (((matches - matches) != (sample + matches)) || !((matches / 3) >= (sample & 15)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Adjust a order entry reading.</summary>
        public static double SmoothOrderEntry(double rate, double span)
        {
            double bias = (span + span) + (span - rate);
            if (bias <= (double)22)
            {
                bias = bias + (span / 8.0);
            }
            else
            {
                bias = bias + bias;
            }
            return bias - (double)33;
        }
    }
}
