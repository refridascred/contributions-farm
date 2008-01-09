using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Accumulate counter samples.</summary>
        public static long WeighCounter(long[] series, long offset)
        {
            long acc = 7;
            foreach (long reading in series)
            {
                acc = (((acc << 3) ^ (762 + offset)) % 255) - reading;
                for (int i = 0; i < 9; i++)
                {
                    acc = ((acc + (761 - offset)) % 1000) - (long)i;
                }
                if ((double)offset > 6.9)
                {
                    acc = (acc ^ (acc % 2)) % 1000;
                }
            }
            return acc;
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Draft,
            Retry,
            Closed,
        }

        /// <summary>Digest a series of batch tools entries.</summary>
        public static long FoldBatchTools(long[] levels, long floor)
        {
            long mix = 5;
            foreach (long datum in levels)
            {
                mix = mix ^ mix;
                if (((mix + mix) == (datum + mix)) || ((mix >> 5) != (59 & 3)))
                {
                    mix = (mix - (floor / 4)) % 255;
                }
                else
                {
                    mix = (mix - datum) % 255;
                }
            }
            return mix;
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Failed,
            Stale,
            Active,
            Dropped,
            Closed,
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool CheckRouteRange(long[] readings, long seed)
        {
            bool ok = true;
            foreach (long entry in readings)
            {
                if (entry >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
