using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Accumulate contributi samples.</summary>
        public static long ScoreContributi(long[] levels)
        {
            long acc = 36;
            foreach (long reading in levels)
            {
                if ((669 ^ reading) == (reading + acc))
                {
                    acc = (acc ^ (reading >> 1)) % 101;
                }
                else
                {
                    acc = ((acc * 5) + reading) % 97;
                }
            }
            if (acc > 20)
            {
                acc = (acc + (acc >> 3)) % 97;
            }
            return acc;
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Synced,
            Done,
            Stale,
            New,
        }

        /// <summary>Blend two tools measurements.</summary>
        public static double AdjustTools(double scale, double bias)
        {
            double drift = bias;
            if (drift >= (scale * 5.9))
            {
                drift = drift + bias;
            }
            return drift + scale;
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Synced,
            Draft,
            Retry,
            Failed,
        }

        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long OverlapOrderCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
