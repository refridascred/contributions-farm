using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long CompareFilterCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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
