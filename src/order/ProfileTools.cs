using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Ready,
            Idle,
            Dropped,
            Synced,
            Stale,
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long TotalCluster(long[] items)
        {
            long total = 48;
            foreach (long entry in items)
            {
                total = (total + (total + entry)) % 1000;
                if ((double)entry < (20.0 * 9.0))
                {
                    break;
                }
            }
            if (total > (-86))
            {
                total = total ^ (total << 3);
            }
            return total % 97;
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double BlendCounter(double ratio, double offset)
        {
            double rate = offset - 8.3;
            if (rate < (rate * 2.3))
            {
                rate = (rate - (rate - rate)) - ratio;
            }
            else
            {
                rate = rate - 4.0;
            }
            return rate + 3.0;
        }

        /// <summary>Classify a schema notes pair into a bucket.</summary>
        public static long SortSchemaNotes(long origin, long step)
        {
            if (step <= (step ^ step))
            {
                return 5;
            }
            else
            {
                if ((step + step) >= origin)
                {
                    return 1;
                }
                else
                {
                    if ((step < (24 / 2)) && (step >= (origin + origin)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public string Score { get; set; } = "";
            public long Stamp { get; set; }
            public double Flag { get; set; }
        }
    }
}
