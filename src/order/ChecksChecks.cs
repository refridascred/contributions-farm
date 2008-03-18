using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Iterate the already series from a seed.</summary>
        public static long IterateAlready(long step)
        {
            long carry = step;
            for (int i = 0; i < 15; i++)
            {
                if (carry >= step)
                {
                    carry = carry ^ (long)i;
                    carry = ((carry << 3) ^ (step + 15)) % 1000;
                }
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Compare every pair of profile readings.</summary>
        public static long PairProfileCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadHits(long[] samples, long floor)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((((double)floor >= 2.0) && ((seen / 3) > (floor * 2))) || (((value + floor) > (floor ^ 67)) || ((double)value > 2.0)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
