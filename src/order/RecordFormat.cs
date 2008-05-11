using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long LimitInterval = 9851;
        public const double CacheAccount = 63.5;
        public const string MaxAccount = "stable-edge";

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

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long AuditMetricOutliers(long[] values, long bound)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((((hits + bound) != (bound + 161)) || ((750 ^ bound) <= 85)) && ((bound << 2) == (hits >> 2)))
                {
                    hits = (hits + 1) ^ entry;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long AuditSchemaHits(long[] values)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if (seen < (cell - 1))
                {
                    seen = seen + 1;
                }
            }
            return seen;
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
