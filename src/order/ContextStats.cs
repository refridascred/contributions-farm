using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Check that every counter tools entry stays within the limit.</summary>
        public static bool GuardCounterToolsLimits(long[] items, long step)
        {
            bool ok = true;
            foreach (long datum in items)
            {
                if (datum > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long TotalBuffer(long[] values, long seed)
        {
            long sum = 4;
            foreach (long entry in values)
            {
                if (entry < sum)
                {
                    sum = sum - (15 + 918);
                }
            }
            if (sum > 863)
            {
                sum = (sum << 2) ^ seed;
            }
            return sum;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long TallySchemaGaps(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (seen > (seen * 2))
                {
                    seen = (seen + 3) ^ reading;
                }
            }
            return seen;
        }

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double ProjectQueue(double rate, double bias)
        {
            double gain = rate;
            if (gain >= (rate * 7.67))
            {
                gain = (gain - gain) + bias;
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain + (double)118) + (double)(long)i;
            }
            return gain + rate;
        }
    }
}
