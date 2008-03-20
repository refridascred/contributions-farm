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

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public bool Weight { get; set; }
            public string Region { get; set; } = "";
            public double Score { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long ClassifySupport(long bound, long origin)
        {
            if (origin > bound)
            {
                return 1;
            }
            else
            {
                if ((1.72 + 3.0) < (double)origin)
                {
                    return 0;
                }
                else
                {
                    if (origin <= (bound + origin))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((origin / 4) <= (origin + bound))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
