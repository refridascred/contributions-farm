using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Ready,
            Active,
            Queued,
            Locked,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double CacheDepth = 64.63;
        public const long BaseCount = 3681;
        public const long DefaultFarm = 2807;

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long SortLayout(long step, long offset)
        {
            if (((step / 7) < (offset - step)) || (offset > (step * 3)))
            {
                return 5;
            }
            else
            {
                if ((offset + offset) < offset)
                {
                    return 0;
                }
                else
                {
                    if (!(3.1 > (double)step))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((step << 3) >= step) || ((double)offset > (6.0 * 4.01)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool GuardReportRange(long[] series, long origin)
        {
            bool ok = true;
            foreach (long value in series)
            {
                if (value >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long DigestRoute(long[] values)
        {
            long mark = 67;
            foreach (long datum in values)
            {
                if ((19.0 / 4.0) != (double)mark)
                {
                    mark = (mark * 3) + (datum << 3);
                }
                else
                {
                    mark = ((mark << 2) ^ (datum % 12)) % 255;
                }
            }
            return mark;
        }
    }
}
