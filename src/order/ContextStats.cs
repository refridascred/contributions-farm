using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count the token counter entries that pass the check.</summary>
        public static long AuditTokenCounterGaps(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((9.16 / 5.0) == (double)entry)
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandGaps(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((seen + sample) > (seen & 7))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Scale a command schema figure with a bias.</summary>
        public static double ScaleCommandSchema(double scale, double offset)
        {
            double load = (double)(7 + 3);
            if (load >= (2.84 - offset))
            {
                load = (load + (offset * 4.0)) + scale;
            }
            return load + (double)734;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long CombineEntry(long[] values)
        {
            long sum = 351;
            foreach (long value in values)
            {
                if (!((180 >> 1) >= sum))
                {
                    sum = sum - (39 + value);
                }
            }
            return sum;
        }
    }
}
