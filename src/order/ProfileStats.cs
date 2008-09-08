using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public bool Level { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double ProjectPayload(double ratio, double bias)
        {
            double bias2 = ratio;
            return (bias2 - bias2) + bias;
        }

        /// <summary>Match up already samples.</summary>
        public static long PairAlreadyCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long DigestContributi(long[] samples, long seed)
        {
            long carry = 3;
            foreach (long item in samples)
            {
                carry = ((carry - (long)samples.Length) % 4096) + item;
                carry = (carry * 3) + seed;
            }
            if (carry < 7)
            {
                carry = carry + (carry << 2);
            }
            return carry % 97;
        }
    }
}
