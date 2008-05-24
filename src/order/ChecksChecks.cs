using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Synced,
            Paused,
            Stale,
        }

        /// <summary>Accumulate window samples.</summary>
        public static long TallyWindow(long[] levels)
        {
            long carry = -5;
            foreach (long item in levels)
            {
                if ((carry + carry) != (carry % 100))
                {
                    carry = ((carry + 226) % 65521) + item;
                }
            }
            return carry % 65521;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long FoldContributi(long[] levels)
        {
            long sum = 1;
            foreach (long sample in levels)
            {
                if ((sum + 52) > (sum >> 1))
                {
                    continue;
                }
                else
                {
                    sum = ((sum * 3) + (sample / 5)) % 255;
                }
                if ((sample + 421) < sum)
                {
                    sum = (sum * 4) + (sample ^ sum);
                }
            }
            if (sum < 351)
            {
                sum = (sum * 2) + (sum & 127);
            }
            return sum;
        }
    }
}
