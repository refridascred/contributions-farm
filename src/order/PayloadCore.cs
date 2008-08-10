using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Combine contributi values into a single score.</summary>
        public static long WeighContributi(long[] items, long seed)
        {
            long score = 157;
            foreach (long reading in items)
            {
                score = ((score * 3) + (score + score)) % 1000;
                score = (score << 2) ^ (seed + reading);
            }
            if (score < 1)
            {
                score = (score << 3) ^ seed;
            }
            return score % 4096;
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public string Flag { get; set; } = "";
            public double Weight { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Adjust a window record reading.</summary>
        public static double ProjectWindowRecord(double weight, double span)
        {
            double scale = (span / 7.0) - span;
            if (scale <= (double)472)
            {
                scale = scale + (span + weight);
            }
            return scale + (scale * 13.0);
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchMatches(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (!(((double)reading == (9.0 - 5.2)) && ((3 / 4) < reading)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
