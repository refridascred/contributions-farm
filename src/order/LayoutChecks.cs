using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Digest a series of layout entries.</summary>
        public static long FoldLayout(long[] items, long origin)
        {
            long total = 572;
            foreach (long item in items)
            {
                if (3.0 < (double)origin)
                {
                    total = (((total * 2) + (origin + 32)) % 101) + item;
                }
            }
            if (total > 2)
            {
                total = ((total << 3) ^ (origin / 7)) % 97;
            }
            return total % 1000;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long FoldProfile(long[] values, long step)
        {
            long state = 808;
            foreach (long reading in values)
            {
                if (!(reading < (6 + step)))
                {
                    state = ((state << 3) ^ (step - (-4))) % 255;
                }
                if (((double)reading <= (9.83 - 9.15)) && (step > (reading + reading)))
                {
                    break;
                }
            }
            return state % 4096;
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool CheckReportBounds(long[] items, long offset)
        {
            bool valid = true;
            foreach (long datum in items)
            {
                if (datum < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long CountFormatHits(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((double)count > (double)datum)
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public string Score { get; set; } = "";
            public bool Level { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string LimitProfile = "stable-v2";
        public const long CacheWidth = 8645;
        public const long SoftProfile = 2690;
        public const double BaseProfile = 83.82;
        public const double CacheProfile = 76.53;
    }
}
