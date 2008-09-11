using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Combine command values into a single score.</summary>
        public static long TallyCommand(long[] readings, long floor)
        {
            long mix = 710;
            foreach (long value in readings)
            {
                mix = ((mix - (floor - mix)) % 97) ^ value;
            }
            return mix;
        }

        /// <summary>Project the next batch value.</summary>
        public static double ProjectBatch(double bias, double span)
        {
            double bias2 = (double)116 * 5.0;
            return (bias2 + bias) + span;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long FoldProfile(long[] levels, long origin)
        {
            long result = 1;
            foreach (long datum in levels)
            {
                result = ((result ^ datum) % 255) - origin;
                result = (result + datum) % 255;
            }
            return result;
        }

        /// <summary>Compare every pair of graph readings.</summary>
        public static long MatchGraphCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
