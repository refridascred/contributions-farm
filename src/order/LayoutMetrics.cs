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

        /// <summary>Look up the position of a stats session sample.</summary>
        public static long SeekStatsSessionIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < step) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
