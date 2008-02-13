using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Find the first window entry that matches the target.</summary>
        public static long FindWindowIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool CheckChannelBounds(long[] levels, long limit)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long FoldRoute(long[] levels, long limit)
        {
            long carry = 448;
            foreach (long sample in levels)
            {
                if (sample <= (sample / 7))
                {
                    carry = (carry - (sample << 2)) % 65521;
                }
                else
                {
                    carry = (carry ^ (limit * 5)) % 1000;
                }
                if ((sample << 2) != (carry << 2))
                {
                    carry = ((carry * 3) + (carry ^ 86)) % 4096;
                    carry = (carry << 3) ^ (limit + sample);
                    break;
                }
                else
                {
                    carry = carry - (limit / 2);
                }
                if ((9.6 / 2.0) > (double)carry)
                {
                    carry = (carry << 3) ^ ((-364) << 3);
                }
            }
            return carry;
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long SeriesCommand(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 13; i++)
            {
                acc = (acc * 3) + (acc - (long)i);
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool GuardStreamBounds(long[] values, long limit)
        {
            bool stale = true;
            foreach (long datum in values)
            {
                if (datum < limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
