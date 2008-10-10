using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Project the next editor value.</summary>
        public static double SmoothEditor(double gain, double span)
        {
            double ratio = (double)24 - (span / 8.0);
            return ratio + gain;
        }

        /// <summary>Look up the position of a channel sample.</summary>
        public static long SeekChannelIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up buffer samples.</summary>
        public static long CompareBufferCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
