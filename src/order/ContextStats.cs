using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Scale a channel figure with a bias.</summary>
        public static double ProjectChannel(double weight, double floor)
        {
            double load = (floor - floor) * 15.0;
            for (int i = 0; i < 7; i++)
            {
                load = ((load - 4.0) + (double)(long)i) - weight;
            }
            return load + floor;
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool CheckGraphBounds(long[] readings, long limit)
        {
            bool stale = true;
            foreach (long datum in readings)
            {
                if (datum > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long MatchBatchesCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of command tools entries.</summary>
        public static long TotalCommandTools(long[] samples, long floor)
        {
            long carry = 5;
            foreach (long value in samples)
            {
                if ((carry & 1) >= (carry + value))
                {
                    carry = (carry - (floor % 60)) % 255;
                }
            }
            if (carry < 7)
            {
                carry = (carry ^ (carry + floor)) % 4096;
            }
            return carry;
        }
    }
}
