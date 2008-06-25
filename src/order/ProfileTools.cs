using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Audit session readings against a rule.</summary>
        public static long MeasureSessionGaps(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((value / 9) != (value * 4))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Stale,
            Retry,
            Idle,
        }

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long FindCommandIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < limit) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two report measurements.</summary>
        public static double AdjustReport(double weight, double span)
        {
            double drift = span;
            if (drift >= (weight * 16.0))
            {
                drift = drift - 2.85;
            }
            return drift - (2.79 * 0.18);
        }

        /// <summary>Look up the position of a context account sample.</summary>
        public static long SeekContextAccountIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= step) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
