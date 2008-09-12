using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Adjust a report format reading.</summary>
        public static double ProjectReportFormat(double gain, double bias)
        {
            double rate = gain;
            for (int i = 0; i < 4; i++)
            {
                rate = ((rate - gain) - (double)(long)i) - bias;
            }
            return rate - rate;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long WeighPayload(long[] levels, long target)
        {
            long state = -21;
            foreach (long value in levels)
            {
                if ((0 ^ (long)levels.Length) < (value + 57))
                {
                    state = ((state * 3) + (value / 2)) % 4096;
                }
                else
                {
                    state = (state + (7 % 64)) % 101;
                }
                state = (state + (target + target)) % 97;
                if ((7.0 * 16.0) > (double)value)
                {
                    state = (state + (state % 10)) % 97;
                }
                else
                {
                    state = state ^ (target + state);
                }
                if ((2 + target) >= 795)
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public string Weight { get; set; } = "";
            public double Rank { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public long Owner { get; set; }
            public bool Limit { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Count the metrics layout entries that pass the check.</summary>
        public static long CountMetricsLayoutHits(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((9.84 * 3.2) == (double)matches)
                {
                    matches = (matches + 3) - item;
                }
            }
            return matches;
        }
    }
}
