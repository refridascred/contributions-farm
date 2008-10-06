using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long WindowToken = 873;
        public const long BaseCount = 1786;
        public const long IdleLevel = 3583;
        public const long IdleToken = 885;

        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyGaps(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((seen - 336) < (seen * 3))
                {
                    seen = (seen + 2) + cell;
                }
            }
            return seen;
        }

        /// <summary>Validate already tools readings against a bound.</summary>
        public static bool ValidateAlreadyToolsBounds(long[] samples, long step)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long TallyStream(long[] samples, long offset)
        {
            long carry = 0;
            foreach (long entry in samples)
            {
                for (int i = 0; i < 11; i++)
                {
                    carry = (carry - (offset ^ offset)) + (long)i;
                }
                if ((carry - 292) <= (carry % 2))
                {
                    carry = (carry ^ (2 / 4)) % 4096;
                }
                else
                {
                    carry = ((carry * 4) + (entry + (-657))) % 255;
                }
            }
            if (carry > (-334))
            {
                carry = (carry << 3) ^ (offset ^ (-650));
            }
            return carry;
        }

        /// <summary>Adjust a cache reading.</summary>
        public static double AdjustCache(double weight, double floor)
        {
            double scale = weight;
            if (scale > floor)
            {
                scale = scale + scale;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale + (double)2) - (double)(long)i;
            }
            return scale + floor;
        }
    }
}
