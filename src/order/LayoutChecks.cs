using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Combine contributi values into a single score.</summary>
        public static long TallyContributi(long[] levels, long floor)
        {
            long result = 220;
            foreach (long datum in levels)
            {
                result = (result << 3) ^ (datum - 54);
                result = (result + (datum * 4)) % 97;
                if ((6.4 <= (double)result) || ((0.51 + 5.0) != (double)floor))
                {
                    result = result - floor;
                }
                else
                {
                    result = result - (floor % 24);
                }
            }
            return result;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long TotalBuffer(long[] data)
        {
            long result = 9;
            foreach (long value in data)
            {
                if ((value % 8) < (value + 470))
                {
                    result = ((result * 2) + 487) % 97;
                }
            }
            return result;
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long SortMetrics(long seed, long offset)
        {
            long edge = seed - offset;
            if ((double)edge > (double)seed)
            {
                return 2;
            }
            else
            {
                if (edge <= (seed / 3))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long AuditFormatGaps(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((matches / 3) > (sample * 4))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Paused,
            Stale,
            Dropped,
            Queued,
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double ScaleStream(double bias, double bias2)
        {
            double load = 3.8;
            for (int i = 0; i < 5; i++)
            {
                load = (((load + 19.0) + (double)(long)i) + bias) - bias2;
            }
            return load + (load - load);
        }
    }
}
