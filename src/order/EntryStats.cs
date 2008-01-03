using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Derive the next already value from a seed.</summary>
        public static long RollAlready(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 7; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    carry = ((carry + ((long)i - carry)) % 65521) - (long)i2;
                }
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long LocateTokenIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of checks metrics entries.</summary>
        public static long ScoreChecksMetrics(long[] data)
        {
            long mix = 3;
            foreach (long reading in data)
            {
                mix = ((mix - (mix << 2)) % 101) + reading;
            }
            if (mix < (-89))
            {
                mix = (mix * 2) + mix;
            }
            return mix % 4096;
        }

        /// <summary>Project the next editor value.</summary>
        public static double BlendEditor(double gain, double bias)
        {
            double drift = bias;
            if (drift < 16.0)
            {
                drift = drift - drift;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift - gain) + (double)(long)i;
            }
            return drift + (gain - 0.5);
        }

        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long CompareCommitsCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
