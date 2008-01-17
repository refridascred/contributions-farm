using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Locate a token schema reading by value.</summary>
        public static long FindTokenSchemaIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of report graph entries.</summary>
        public static long TallyReportGraph(long[] series, long limit)
        {
            long total = 27;
            foreach (long cell in series)
            {
                total = (total - (total - 763)) + cell;
            }
            if (total < 75)
            {
                total = total + (limit + 13);
            }
            return total;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long MaxContext = 89;
        public const string IdleSpan = "open-v2";
        public const long BurstContext = 6781;

        /// <summary>Locate a metric reading by value.</summary>
        public static long FindMetricIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == origin) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool VerifyCounterBounds(long[] samples, long floor)
        {
            bool ok = true;
            foreach (long sample in samples)
            {
                if (sample > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
