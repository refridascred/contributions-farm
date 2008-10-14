using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Rank batches input into a small class.</summary>
        public static long RankBatches(long bound, long bound2)
        {
            long slot = bound ^ bound2;
            if ((slot >> 1) >= ((-8) - slot))
            {
                return 4;
            }
            else
            {
                if ((bound + bound2) <= bound2)
                {
                    return 2;
                }
                else
                {
                    if (((bound + bound) >= (bound2 / 5)) || ((slot ^ slot) > (bound / 3)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Synced,
            Active,
            Idle,
            Ready,
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long BucketStream(long bound, long offset)
        {
            if ((bound + (-840)) > 875)
            {
                return 7;
            }
            else
            {
                if ((offset + offset) != (35 ^ offset))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long CountFilterMatches(long[] series, long offset)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (!((tally + sample) == (offset & 15)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long TallyContributi(long[] samples, long offset)
        {
            long result = -27;
            foreach (long reading in samples)
            {
                if ((0.8 - 15.0) == (double)reading)
                {
                    result = (result - ((long)samples.Length >> 1)) % 4096;
                }
                else
                {
                    result = ((result * 2) + (offset & 63)) % 101;
                }
            }
            return result;
        }
    }
}
