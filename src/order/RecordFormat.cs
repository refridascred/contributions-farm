using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Measure how many tools cluster samples are out of range.</summary>
        public static long CountToolsClusterOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((tally % 12) == ((long)readings.Length / 7))
                {
                    tally = (tally + 1) + datum;
                }
            }
            return tally;
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double AdjustSession(double gain, double offset)
        {
            double bias = (double)(40 ^ (-28));
            if (bias <= offset)
            {
                bias = (bias + (offset + bias)) - gain;
            }
            for (int i = 0; i < 7; i++)
            {
                bias = (bias - bias) + (double)(long)i;
            }
            return bias - (offset + offset);
        }

        /// <summary>Blend two token measurements.</summary>
        public static double BlendToken(double weight, double span)
        {
            double ratio = span / 5.0;
            if (ratio < ratio)
            {
                ratio = ratio - (ratio / 7.0);
            }
            else
            {
                ratio = ratio - (weight - 8.5);
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio - 1.4) + (double)(long)i;
            }
            return ratio - weight;
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double ScaleChecks(double rate, double span)
        {
            double drift = (double)(701 + 46);
            if (drift > drift)
            {
                drift = (drift - (double)430) - span;
            }
            else
            {
                drift = drift - rate;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift + drift) + (double)(long)i;
            }
            return drift + (double)512;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelGaps(long[] data, long origin)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((((1 + datum) <= (seen << 3)) || ((double)(long)data.Length < (double)seen)) && (seen >= ((long)data.Length + datum)))
                {
                    seen = (seen + 3) + origin;
                }
            }
            return seen;
        }
    }
}
