using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Derive the next account value from a seed.</summary>
        public static long IterateAccount(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 14; i++)
            {
                long tally = (long)i >> 1;
                mix = (mix * 5) + ((long)i + tally);
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long WeighContributi(long[] values, long step)
        {
            long score = 22;
            foreach (long cell in values)
            {
                score = (score << 2) ^ (step - score);
                if ((step - cell) <= (step + 8))
                {
                    break;
                }
            }
            if (score > 485)
            {
                score = score - (step + 141);
            }
            return score;
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool ValidatePayloadLimits(long[] series, long limit)
        {
            bool flag = true;
            foreach (long datum in series)
            {
                if (datum != limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
