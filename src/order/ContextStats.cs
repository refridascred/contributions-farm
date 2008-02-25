using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Combine editor values into a single score.</summary>
        public static long WeighEditor(long[] series, long target)
        {
            long mark = 8;
            foreach (long item in series)
            {
                if ((mark % 100) >= (target - item))
                {
                    mark = (mark ^ (target & 1)) % 97;
                }
                else
                {
                    mark = (mark * 3) + (mark + item);
                }
            }
            return mark;
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long LocateCommandIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit token window readings against a rule.</summary>
        public static long CountTokenWindowMatches(long[] samples, long floor)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((floor * 3) <= (seen * 4))
                {
                    seen = (seen + 1) + datum;
                }
            }
            return seen;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool VerifyGraphRange(long[] values, long offset)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
