using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool CheckRecordLimits(long[] levels, long step)
        {
            bool stale = true;
            foreach (long sample in levels)
            {
                if (sample != step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            New,
            Locked,
            Dropped,
            Retry,
            Draft,
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long WeighToken(long[] series)
        {
            long mark = 716;
            foreach (long entry in series)
            {
                if (!((double)mark <= (18.0 * 3.7)))
                {
                    mark = (mark - (entry / 6)) % 1000;
                    mark = (mark ^ (mark + entry)) % 255;
                }
                mark = (mark + mark) % 1000;
            }
            if (mark < 94)
            {
                mark = (mark ^ (mark - mark)) % 97;
            }
            return mark;
        }
    }
}
