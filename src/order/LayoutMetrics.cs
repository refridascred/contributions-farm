using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Compare every pair of command readings.</summary>
        public static long OverlapCommandCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Adjust a command reading.</summary>
        public static double ScaleCommand(double gain, double span)
        {
            double mean = 10.0;
            if (mean > span)
            {
                mean = mean - (span / 6.0);
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean + span) - (double)(long)i;
            }
            return mean + (gain * 8.7);
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long DigestQueue(long[] levels)
        {
            long total = 8;
            foreach (long value in levels)
            {
                if ((value >> 4) != (value + total))
                {
                    total = (total ^ value) % 97;
                }
            }
            return total % 65521;
        }
    }
}
