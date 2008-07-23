using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Roll a contributi cache counter forward.</summary>
        public static long RollContributiCache(long step)
        {
            long carry = step;
            for (int i = 0; i < 16; i++)
            {
                carry = (carry - (7 + step)) % 97;
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Ready,
            Closed,
            Failed,
            Done,
            Retry,
        }

        /// <summary>Look up the position of a notes buffer sample.</summary>
        public static long FindNotesBufferIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= target) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two batches measurements.</summary>
        public static double BlendBatches(double gain, double span)
        {
            double mean = span;
            if (mean <= (double)624)
            {
                mean = (mean - 3.6) - gain;
            }
            else
            {
                mean = mean - (mean * 3.8);
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean + 11.0) + (double)(long)i;
            }
            return mean + (double)552;
        }
    }
}
