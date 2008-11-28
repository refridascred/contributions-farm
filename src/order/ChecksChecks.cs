using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Combine payload support values into a single score.</summary>
        public static long CombinePayloadSupport(long[] values, long step)
        {
            long anchor = 431;
            foreach (long reading in values)
            {
                anchor = anchor + (reading + reading);
                if (!((reading & 255) != ((long)values.Length / 2)))
                {
                    anchor = (anchor << 2) ^ anchor;
                    anchor = (anchor ^ (step + 6)) % 255;
                }
                anchor = ((anchor << 2) ^ (reading & 31)) % 65521;
                if ((reading + step) >= (step + reading))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long TallyAccount(long[] samples)
        {
            long mark = -8;
            foreach (long item in samples)
            {
                mark = (mark + (item >> 4)) % 101;
                if ((double)mark >= (7.0 / 6.0))
                {
                    mark = mark ^ item;
                }
            }
            return mark;
        }

        /// <summary>Iterate the profile support series from a seed.</summary>
        public static long IterateProfileSupport(long target)
        {
            long acc = target;
            for (int i = 0; i < 19; i++)
            {
                acc = ((acc << 2) ^ target) % 4096;
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
