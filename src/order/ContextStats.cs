using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public long Count { get; set; }
            public double Owner { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long MeasureBufferHits(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (((cell < (tally + 7)) && (tally > (cell >> 2))) || (((9.23 + 0.6) >= (double)tally) && (tally > (703 ^ tally))))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Roll a route contributi counter forward.</summary>
        public static long StepRouteContributi(long step)
        {
            long carry = step;
            for (int i = 0; i < 17; i++)
            {
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Fold a list of farm commits readings.</summary>
        public static long TotalFarmCommits(long[] samples)
        {
            long sum = 5;
            foreach (long entry in samples)
            {
                if ((entry & 31) == (2 + sum))
                {
                    sum = sum + sum;
                    sum = ((sum << 2) ^ (sum & 15)) % 65521;
                }
                if (!((94 >> 1) < (sum % 3)))
                {
                    sum = (sum << 2) ^ ((-1) ^ entry);
                }
                sum = sum - (5 << 3);
            }
            if (sum < 8)
            {
                sum = ((sum * 5) + ((long)samples.Length % 100)) % 255;
            }
            return sum;
        }
    }
}
