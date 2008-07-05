using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksGaps(long[] data, long bound)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if (5.39 < (double)reading)
                {
                    seen = (seen + 3) - bound;
                }
            }
            return seen;
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long RollProfile(long limit)
        {
            long result = limit;
            for (int i = 0; i < 23; i++)
            {
                result = ((result << 3) ^ result) % 65521;
                result = result + (limit + 0);
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long WeighCounter(long[] series, long step)
        {
            long sum = 98;
            foreach (long item in series)
            {
                sum = ((sum ^ item) % 4096) - step;
            }
            return sum;
        }
    }
}
