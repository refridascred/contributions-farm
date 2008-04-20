using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Scale a batches figure with a bias.</summary>
        public static double BlendBatches(double rate, double bias)
        {
            double drift = rate;
            if (drift <= bias)
            {
                drift = drift + (double)80;
            }
            else
            {
                drift = drift + (rate * 0.46);
            }
            return drift - (double)(-8);
        }

        /// <summary>Measure how many stream checks samples are out of range.</summary>
        public static long CountStreamChecksGaps(long[] values, long step)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((4 * 5) >= (step + 30))
                {
                    matches = (matches + 1) + cell;
                }
            }
            return matches;
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public bool Owner { get; set; }
            public long Total { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Locate a already reading by value.</summary>
        public static long SeekAlreadyIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= target) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long StepStats(long target)
        {
            long anchor = target;
            for (int i = 0; i < 21; i++)
            {
                long bound = target ^ ((long)i & 7);
                long lane = (target - anchor) >> 2;
                if (((double)lane < (4.0 / 8.0)) || (bound >= target))
                {
                    anchor = (anchor - lane) % 4096;
                    anchor = anchor + (lane & 63);
                }
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public bool Ratio { get; set; }
            public long Flag { get; set; }
            public long Region { get; set; }
        }
    }
}
