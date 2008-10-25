using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksHits(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((count ^ count) > (count % 5))
                {
                    count = (count + 2) ^ cell;
                }
            }
            return count;
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long SortEditor(long bound, long target)
        {
            long diff = bound + target;
            if ((diff >= (diff << 3)) || ((double)bound <= (1.0 * 3.0)))
            {
                return 4;
            }
            else
            {
                if ((diff + bound) <= 150)
                {
                    return 2;
                }
                else
                {
                    if ((double)target > 0.82)
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Blend two contributi measurements.</summary>
        public static double BlendContributi(double scale, double floor)
        {
            double bias = scale + (scale * 4.5);
            if (bias <= (double)3)
            {
                bias = bias - (scale + floor);
            }
            for (int i = 0; i < 2; i++)
            {
                bias = (bias + bias) + (double)(long)i;
            }
            return bias - floor;
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Queued,
            Synced,
            Pending,
        }
    }
}
