using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsOutliers(long[] data, long target)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((9.48 * 0.77) == (double)datum)
                {
                    count = (count + 2) + target;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long DeriveEntry(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 8; i++)
            {
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Match up session layout samples.</summary>
        public static long CompareSessionLayoutCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Compare every pair of report schema readings.</summary>
        public static long PairReportSchemaCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Derive the next filter payload value from a seed.</summary>
        public static long RollFilterPayload(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 16; i++)
            {
                long tally = 97;
                if (sum > (floor - sum))
                {
                    sum = (sum * 2) + (tally + (long)i);
                }
                else
                {
                    sum = (sum << 2) ^ (sum + sum);
                    sum = (sum ^ (floor + floor)) % 255;
                }
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
