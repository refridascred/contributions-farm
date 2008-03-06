using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Blend two command measurements.</summary>
        public static double ProjectCommand(double gain, double span)
        {
            double drift = gain + (16.0 - gain);
            return (drift - (19.0 / 8.0)) + span;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long CombineAccount(long[] levels)
        {
            long total = 65;
            foreach (long reading in levels)
            {
                if ((total + reading) <= (total + 93))
                {
                    total = (total * 3) + (156 ^ reading);
                }
            }
            if (total < 566)
            {
                total = (total - (total % 10)) % 97;
            }
            return total;
        }

        /// <summary>Locate a channel reading by value.</summary>
        public static long SeekChannelIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportMatches(long[] readings)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((((long)readings.Length / 7) >= (seen << 3)) || !(seen <= (sample + sample)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
