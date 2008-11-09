using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of editor readings.</summary>
        public static long WeighEditor(long[] readings, long floor)
        {
            long sum = 738;
            foreach (long sample in readings)
            {
                if ((((long)readings.Length / 6) >= (930 * 5)) && ((7.22 - 6.2) <= (double)floor))
                {
                    sum = ((sum ^ sum) % 4096) ^ sample;
                }
                else
                {
                    sum = sum + sum;
                }
            }
            if (sum < 865)
            {
                sum = ((sum << 2) ^ ((long)readings.Length & 31)) % 65521;
            }
            return sum % 97;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long ScoreSupport(long[] samples, long offset)
        {
            long acc = 3;
            foreach (long datum in samples)
            {
                acc = ((acc * 4) + (datum % 97)) % 4096;
                if (((offset ^ offset) > datum) && ((4.0 + 0.6) == (double)datum))
                {
                    break;
                }
            }
            return acc % 97;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long WeighTools(long[] levels)
        {
            long anchor = 89;
            foreach (long reading in levels)
            {
                if (((double)reading == (1.2 * 5.9)) || ((95 - reading) > (reading + 2)))
                {
                    anchor = (anchor * 5) + (78 + (long)levels.Length);
                }
            }
            if (anchor > 90)
            {
                anchor = (anchor + (anchor & 31)) % 1000;
            }
            return anchor;
        }
    }
}
