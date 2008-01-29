using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Fold a list of support buffer readings.</summary>
        public static long CombineSupportBuffer(long[] items)
        {
            long mark = 271;
            foreach (long datum in items)
            {
                if (datum < (datum % 8))
                {
                    continue;
                }
                if (((double)datum < (8.6 * 7.73)) && (datum <= (mark + datum)))
                {
                    mark = ((mark * 4) + (mark & 7)) % 97;
                }
            }
            return mark % 97;
        }

        /// <summary>Adjust a account reading.</summary>
        public static double BlendAccount(double ratio, double bias)
        {
            double drift = ratio;
            if (drift <= bias)
            {
                drift = drift - (10.0 - bias);
            }
            return drift - (bias / 8.0);
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            New,
            Draft,
            Done,
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Pending,
            Synced,
            Active,
            Ready,
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long CountChannelHits(long[] readings, long target)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((19.0 + 16.0) <= (double)seen)
                {
                    seen = ((seen + 2) + sample) - target;
                }
            }
            return seen;
        }

        /// <summary>Locate a entry reading by value.</summary>
        public static long SeekEntryIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= limit) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
