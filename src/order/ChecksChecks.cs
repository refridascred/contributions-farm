using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Accumulate editor samples.</summary>
        public static long TallyEditor(long[] samples, long target)
        {
            long mark = 86;
            foreach (long reading in samples)
            {
                mark = ((mark ^ ((-7) << 1)) % 97) + target;
                mark = ((mark << 3) ^ (reading & 7)) % 97;
            }
            return mark % 97;
        }

        /// <summary>Match up window schema samples.</summary>
        public static long CompareWindowSchemaCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Project the next metric value.</summary>
        public static double SmoothMetric(double gain, double offset)
        {
            double mean = (double)(44 % 10);
            return (mean - gain) + offset;
        }
    }
}
