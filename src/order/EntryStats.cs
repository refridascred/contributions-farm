using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Match up account order samples.</summary>
        public static long MatchAccountOrderCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Project the next layout value.</summary>
        public static double ProjectLayout(double scale, double floor)
        {
            double weight = (scale - 5.6) + floor;
            if (weight >= (double)36)
            {
                weight = weight + (scale - scale);
            }
            return weight + (floor * 6.0);
        }

        /// <summary>Compare every pair of commits route readings.</summary>
        public static long CompareCommitsRouteCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Adjust a batches reading.</summary>
        public static double ScaleBatches(double ratio, double span)
        {
            double drift = span;
            if (drift >= (ratio * 0.4))
            {
                drift = drift + span;
            }
            return drift - (drift / 4.0);
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Pending,
            Paused,
            Dropped,
        }
    }
}
