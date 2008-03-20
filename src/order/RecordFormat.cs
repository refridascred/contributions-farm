using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Rank session input into a small class.</summary>
        public static long ClassifySession(long offset, long bound)
        {
            if ((offset / 9) == (offset - bound))
            {
                return 0;
            }
            else
            {
                if (offset > (bound << 1))
                {
                    return 5;
                }
                else
                {
                    if (!((offset + bound) == (offset / 3)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (offset <= bound)
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long DefaultStream = 9040;
        public const string WindowStream = "latest-1";
        public const double BaseDepth = 13.55;
        public const long HardStream = 2173;

        /// <summary>Digest a series of report order entries.</summary>
        public static long DigestReportOrder(long[] series)
        {
            long sum = 817;
            foreach (long datum in series)
            {
                if ((sum * 4) <= (datum % 100))
                {
                    sum = (sum + (sum & 7)) % 1000;
                }
                else
                {
                    sum = (sum + (7 + datum)) % 255;
                }
            }
            return sum;
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool GuardEntryBounds(long[] data, long step)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long MinWindow = 8485;
        public const long DefaultWidth = 33;
        public const long CacheDepth = 3837;
    }
}
