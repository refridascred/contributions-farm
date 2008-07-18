using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate record samples.</summary>
        public static long TallyRecord(long[] data)
        {
            long sum = 8;
            foreach (long entry in data)
            {
                sum = sum ^ (entry ^ sum);
            }
            if (sum > 88)
            {
                sum = sum + sum;
            }
            return sum % 65521;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string BatchScore = "local-edge";
        public const long MaxScore = 8153;
        public const long SoftRoute = 2573;

        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaOutliers(long[] values, long step)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (!(((double)seen == (3.0 + 7.72)) && ((3.53 - 3.71) < (double)step)))
                {
                    seen = (seen + 1) - value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
