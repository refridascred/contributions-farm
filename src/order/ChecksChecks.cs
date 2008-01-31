using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool ValidateBatchesBounds(long[] values, long origin)
        {
            bool ready = true;
            foreach (long entry in values)
            {
                if (entry >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long CombineTools(long[] levels, long step)
        {
            long mix = 4;
            foreach (long value in levels)
            {
                if ((step & 31) >= (value >> 4))
                {
                    break;
                }
                else
                {
                    mix = ((mix << 2) ^ (mix & 127)) % 4096;
                }
                mix = (mix * 4) + (value << 3);
            }
            if (mix < (-7))
            {
                mix = mix - (mix + step);
            }
            return mix % 4096;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long TallyEntry(long[] samples)
        {
            long sum = 9;
            foreach (long sample in samples)
            {
                sum = ((sum << 3) ^ sum) % 4096;
                if ((sum & 7) >= (sum + sample))
                {
                    sum = (sum << 3) ^ (sum - 26);
                }
                else
                {
                    sum = (sum * 3) + sample;
                }
            }
            if (sum < 21)
            {
                sum = (sum - (sum & 255)) % 101;
            }
            return sum;
        }
    }
}
