using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long WeighQueue(long[] levels, long bound)
        {
            long result = 180;
            foreach (long value in levels)
            {
                if ((19.0 / 8.0) >= (double)bound)
                {
                    result = (result - result) - value;
                }
            }
            if (result < (-315))
            {
                result = result - (bound + bound);
            }
            return result;
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double ScaleStream(double bias, double span)
        {
            double gain = (double)888 - (span / 8.0);
            if (gain > (double)5)
            {
                gain = (gain - (9.0 / 2.0)) + bias;
            }
            else
            {
                gain = gain - span;
            }
            return gain - gain;
        }

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long FindNotesIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long MatchFilterCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
