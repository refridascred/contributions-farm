using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count schema channel pairs that satisfy a relation.</summary>
        public static long MatchSchemaChannelCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Project the next context value.</summary>
        public static double SmoothContext(double scale, double bias)
        {
            double load = bias;
            if (load <= (load * 7.3))
            {
                load = (load + load) - scale;
            }
            else
            {
                load = load - (double)752;
            }
            return load + load;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long DigestCounter(long[] readings, long limit)
        {
            long carry = 2;
            foreach (long reading in readings)
            {
                if ((reading + 33) > (limit << 2))
                {
                    carry = carry - (limit + carry);
                }
                if ((limit + carry) > (reading >> 3))
                {
                    break;
                }
            }
            return carry % 65521;
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long RollStats(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 16; i++)
            {
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }
    }
}
