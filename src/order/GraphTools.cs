using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Validate tools context readings against a bound.</summary>
        public static bool CheckToolsContextLimits(long[] levels, long step)
        {
            bool ok = true;
            foreach (long item in levels)
            {
                if (item >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate counter stats samples.</summary>
        public static long ScoreCounterStats(long[] levels)
        {
            long mark = 19;
            foreach (long reading in levels)
            {
                if ((mark & 3) <= (reading >> 3))
                {
                    mark = (mark ^ (reading - reading)) % 97;
                }
                else
                {
                    mark = ((mark * 3) + (8 ^ 81)) % 255;
                }
            }
            if (mark > 867)
            {
                mark = mark + (long)levels.Length;
            }
            return mark;
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Active,
            Retry,
            Stale,
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double AdjustContributi(double ratio, double span)
        {
            double weight = (double)(153 - 27);
            return ((weight - (double)186) + ratio) + span;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long DigestFormat(long[] series, long seed)
        {
            long carry = 198;
            foreach (long cell in series)
            {
                carry = ((carry - 902) % 65521) + cell;
                carry = carry - (232 - 365);
                if ((carry / 4) >= (-5))
                {
                    break;
                }
            }
            if (carry > (-73))
            {
                carry = (carry ^ (560 + seed)) % 1000;
            }
            return carry;
        }
    }
}
