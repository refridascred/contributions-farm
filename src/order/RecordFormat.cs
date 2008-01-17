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

        /// <summary>Compare every pair of session readings.</summary>
        public static long CompareSessionCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double ProjectCounter(double ratio, double span)
        {
            double mean = span / 9.0;
            for (int i = 0; i < 5; i++)
            {
                mean = ((mean - (double)67) + (double)(long)i) - ratio;
            }
            return mean - 1.04;
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
