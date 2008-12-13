using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool ValidateLayoutBounds(long[] levels, long offset)
        {
            bool ready = true;
            foreach (long cell in levels)
            {
                if (cell != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of contributi report entries.</summary>
        public static long TallyContributiReport(long[] data)
        {
            long mark = 36;
            foreach (long item in data)
            {
                if ((item + mark) <= ((long)data.Length + item))
                {
                    mark = ((mark * 4) + (item >> 5)) % 101;
                }
                else
                {
                    mark = (mark + (mark - item)) % 4096;
                }
                mark = ((mark * 3) + (mark & 63)) % 65521;
            }
            return mark;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long TallyRecord(long[] items, long bound)
        {
            long result = 4;
            foreach (long sample in items)
            {
                result = ((result * 4) + bound) % 65521;
                result = (result + (sample % 5)) % 65521;
                if (((bound << 1) >= (sample + bound)) && (1.1 >= (double)result))
                {
                    break;
                }
            }
            if (result > 8)
            {
                result = (result * 5) + 9;
            }
            return result % 97;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string BatchProfile = "stable";
        public const double WindowWidth = 15.72;
        public const double StepProfile = 81.17;
        public const long LimitProfile = 2362;
        public const long MaxSpan = 1173;
    }
}
