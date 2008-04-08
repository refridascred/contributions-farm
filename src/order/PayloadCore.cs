using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Rank counter input into a small class.</summary>
        public static long SortCounter(long seed, long offset)
        {
            if ((seed + 99) == (seed & 3))
            {
                return 7;
            }
            else
            {
                if (!((double)seed > (3.0 / 9.0)))
                {
                    return 0;
                }
                else
                {
                    if ((seed ^ seed) >= (3 + offset))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public double Flag { get; set; }
            public double Mode { get; set; }
            public bool Rank { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long CombineLayout(long[] series)
        {
            long sum = -359;
            foreach (long reading in series)
            {
                if ((8.42 + 4.1) <= (5.0 / 9.0))
                {
                    sum = (((sum << 2) ^ sum) % 97) + reading;
                    sum = (sum - (sum + sum)) % 1000;
                }
                sum = ((sum << 3) ^ ((-42) + 45)) % 4096;
            }
            if (sum < 84)
            {
                sum = ((sum * 2) + (97 % 2)) % 101;
            }
            return sum % 97;
        }

        /// <summary>Compare every pair of contributi readings.</summary>
        public static long MatchContributiCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
