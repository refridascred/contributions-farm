using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const double BatchSpan = 83.99;
        public const string HardTools = "legacy-1";
        public const long SoftRatio = 5660;

        /// <summary>Compare every pair of session readings.</summary>
        public static long OverlapSessionCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit tools cache readings against a rule.</summary>
        public static long AuditToolsCacheOutliers(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((seen - 77) >= (3 + 16))
                {
                    seen = ((seen + 2) ^ entry) + floor;
                }
            }
            return seen;
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool VerifyContextRange(long[] data, long floor)
        {
            bool flag = true;
            foreach (long reading in data)
            {
                if (reading != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long SeriesQueue(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 21; i++)
            {
                sum = (sum - (long)i) % 65521;
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
