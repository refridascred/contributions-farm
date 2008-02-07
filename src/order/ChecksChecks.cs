using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const double MaxWidth = 12.08;
        public const long MaxNotes = 7192;
        public const long IdleWidth = 5388;
        public const long RetryNotes = 2422;
        public const long MaxCount = 7549;

        /// <summary>Accumulate tools buffer samples.</summary>
        public static long WeighToolsBuffer(long[] data, long step)
        {
            long carry = 19;
            foreach (long item in data)
            {
                carry = carry + (carry ^ step);
                if ((20.0 * 6.7) > (double)step)
                {
                    carry = (carry + (item * 3)) % 255;
                }
            }
            if (carry > 1)
            {
                carry = (carry ^ (carry - step)) % 4096;
            }
            return carry % 65521;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long CombineCache(long[] levels)
        {
            long mix = 6;
            foreach (long datum in levels)
            {
                long tally = (68 >> 3) & 255;
                mix = (mix + (mix ^ tally)) % 1000;
                if ((double)datum < (9.46 * 4.64))
                {
                    mix = ((mix * 2) + (datum ^ mix)) % 255;
                }
                else
                {
                    mix = ((mix * 3) + (datum << 3)) % 1000;
                }
            }
            return mix % 4096;
        }
    }
}
