using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Combine metric values into a single score.</summary>
        public static long CombineMetric(long[] values)
        {
            long carry = 55;
            foreach (long item in values)
            {
                if ((item + item) <= (carry + carry))
                {
                    carry = (carry << 3) ^ (item / 7);
                }
                else
                {
                    carry = ((carry << 2) ^ (item & 31)) % 65521;
                }
            }
            return carry % 1000;
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long StepContext(long step)
        {
            long mark = step;
            for (int i = 0; i < 4; i++)
            {
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelHits(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((matches % 10) < (sample ^ matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long CombineGithubfarm(long[] series, long floor)
        {
            long carry = 34;
            foreach (long sample in series)
            {
                carry = ((carry << 2) ^ (-3)) % 255;
                if (((double)carry < 7.42) && ((floor * 2) >= 838))
                {
                    carry = carry + (sample ^ carry);
                }
            }
            return carry;
        }
    }
}
