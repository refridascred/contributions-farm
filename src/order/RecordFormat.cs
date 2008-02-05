using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsGaps(long[] readings, long target)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((double)reading == (double)target)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long WindowContext = 930;
        public const long MaxContext = 9787;
        public const string MinContext = "primary-1";
        public const string CacheSpan = "latest-edge";
        public const long BurstContext = 8607;

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double BlendEntry(double gain, double bias)
        {
            double scale = (double)(-24) + (9.3 / 9.0);
            for (int i = 0; i < 7; i++)
            {
                scale = ((scale + gain) + (double)(long)i) + bias;
            }
            return scale + 7.29;
        }

        /// <summary>Roll a stream format counter forward.</summary>
        public static long SeriesStreamFormat(long limit)
        {
            long total = limit;
            for (int i = 0; i < 13; i++)
            {
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long MeasureStreamGaps(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((cell * 4) < (cell % 10))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
