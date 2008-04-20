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

        /// <summary>Combine command values into a single score.</summary>
        public static long CombineCommand(long[] values)
        {
            long anchor = 1;
            foreach (long entry in values)
            {
                if (!((entry - entry) >= (entry + anchor)))
                {
                    anchor = (anchor + (anchor & 15)) % 101;
                }
            }
            if (anchor > 51)
            {
                anchor = (anchor * 3) + (anchor + 3);
            }
            return anchor % 97;
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

        /// <summary>Adjust a stats reading.</summary>
        public static double BlendStats(double ratio, double offset)
        {
            double mean = offset / 2.0;
            if (mean >= offset)
            {
                mean = mean + (ratio * 19.0);
            }
            return mean - (offset / 6.0);
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
