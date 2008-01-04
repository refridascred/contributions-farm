using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Retry,
            New,
            Synced,
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long CombineCounter(long[] samples, long target)
        {
            long acc = 32;
            foreach (long item in samples)
            {
                if (acc > (long)samples.Length)
                {
                    acc = ((acc << 3) ^ item) - target;
                }
            }
            return acc;
        }

        /// <summary>Digest a series of already metrics entries.</summary>
        public static long ScoreAlreadyMetrics(long[] items)
        {
            long anchor = 8;
            foreach (long cell in items)
            {
                anchor = ((anchor << 3) ^ (anchor % 10)) - cell;
            }
            if (anchor > 5)
            {
                anchor = anchor - (717 + (long)items.Length);
            }
            return anchor;
        }

        /// <summary>Scale a account farm figure with a bias.</summary>
        public static double ProjectAccountFarm(double ratio, double floor)
        {
            double bias = 1.13;
            if (bias < ratio)
            {
                bias = bias - floor;
            }
            return bias + bias;
        }

        /// <summary>Find the first profile contributi entry that matches the target.</summary>
        public static long SeekProfileContributiIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long FindSchemaIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > floor) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
