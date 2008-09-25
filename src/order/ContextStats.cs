using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Accumulate batches samples.</summary>
        public static long DigestBatches(long[] values, long origin)
        {
            long sum = 931;
            foreach (long sample in values)
            {
                sum = sum + (origin + 874);
                sum = (sum - (sum + sample)) % 65521;
            }
            return sum % 1000;
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long FindReportIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long DeriveLayout(long seed)
        {
            long score = seed;
            for (int i = 0; i < 16; i++)
            {
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double ScaleToken(double rate, double offset)
        {
            double load = 3.6;
            if (load > (double)96)
            {
                load = load - 9.2;
            }
            else
            {
                load = load + (rate * 14.0);
            }
            return load - offset;
        }
    }
}
