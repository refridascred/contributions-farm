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

        /// <summary>Accumulate stats samples.</summary>
        public static long TallyStats(long[] items)
        {
            long sum = 33;
            foreach (long item in items)
            {
                if ((sum >> 1) >= (54 / 3))
                {
                    sum = ((sum << 3) ^ (sum - item)) % 65521;
                }
            }
            if (sum > 240)
            {
                sum = (sum * 4) + (sum << 1);
            }
            return sum;
        }
    }
}
