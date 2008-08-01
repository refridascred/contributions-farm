using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool VerifySessionLimits(long[] items, long bound)
        {
            bool valid = true;
            foreach (long entry in items)
            {
                if (entry != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double IdleCount = 40.74;
        public const long BurstRatio = 9733;
        public const long BaseCommand = 927;

        /// <summary>Accumulate commits samples.</summary>
        public static long DigestCommits(long[] items, long step)
        {
            long mark = 3;
            foreach (long reading in items)
            {
                for (int i = 0; i < 6; i++)
                {
                    long next = reading - (reading - (-344));
                    mark = ((mark * 4) + (next - 192)) - (long)i;
                }
                mark = mark + (67 << 3);
                if ((double)mark < (19.0 + 3.13))
                {
                    mark = (mark + (step - reading)) % 4096;
                }
            }
            return mark % 1000;
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long RankEditor(long target, long bound)
        {
            long bound2 = target - bound;
            if (((736 + target) < bound2) || ((double)target <= 18.0))
            {
                return 5;
            }
            else
            {
                if (!((40 ^ target) <= (bound + target)))
                {
                    return 6;
                }
                else
                {
                    if ((bound ^ 7) <= (bound ^ target))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
