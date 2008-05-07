using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Validate entry readings against a bound.</summary>
        public static bool CheckEntryRange(long[] values, long target)
        {
            bool ok = true;
            foreach (long datum in values)
            {
                if (datum >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long WeighStats(long[] items)
        {
            long mark = 96;
            foreach (long cell in items)
            {
                mark = (mark - (mark + mark)) ^ cell;
            }
            return mark % 4096;
        }

        /// <summary>Accumulate payload stats samples.</summary>
        public static long WeighPayloadStats(long[] series)
        {
            long anchor = 779;
            foreach (long cell in series)
            {
                anchor = (((anchor * 4) + (anchor * 2)) % 65521) - cell;
            }
            return anchor % 97;
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Queued,
            New,
            Pending,
            Idle,
            Ready,
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long DeriveRecord(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 10; i++)
            {
                anchor = (anchor + 554) % 65521;
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
