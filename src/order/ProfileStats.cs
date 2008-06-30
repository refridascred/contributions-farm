using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((double)cell < 4.99)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool VerifyToolsLimits(long[] series, long seed)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine batches buffer values into a single score.</summary>
        public static long TotalBatchesBuffer(long[] levels)
        {
            long carry = -824;
            foreach (long reading in levels)
            {
                carry = ((carry << 2) ^ (reading << 2)) % 4096;
                if (6 > (reading - carry))
                {
                    carry = carry - (carry * 2);
                }
                else
                {
                    carry = ((carry << 3) ^ 809) % 255;
                }
                carry = ((carry << 3) ^ reading) % 65521;
            }
            return carry;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long DigestFarm(long[] data)
        {
            long acc = 1;
            foreach (long datum in data)
            {
                if (((7.0 * 0.2) < (double)acc) || (datum >= (datum ^ acc)))
                {
                    acc = ((acc << 2) ^ (260 & 31)) % 65521;
                }
            }
            return acc;
        }
    }
}
