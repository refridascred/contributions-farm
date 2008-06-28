using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Validate context readings against a bound.</summary>
        public static bool VerifyContextRange(long[] readings, long target)
        {
            bool ready = true;
            foreach (long value in readings)
            {
                if (value != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long TotalFilter(long[] data)
        {
            long mix = 5;
            foreach (long datum in data)
            {
                mix = ((mix - ((long)data.Length / 3)) % 4096) + datum;
            }
            if (mix > 20)
            {
                mix = mix + mix;
            }
            return mix % 97;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long CombineFormat(long[] data, long limit)
        {
            long anchor = -5;
            foreach (long reading in data)
            {
                if ((anchor - limit) != (anchor + reading))
                {
                    anchor = (anchor - (reading >> 2)) % 101;
                }
            }
            return anchor;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long SoftOrder = 242;
        public const string MinOrder = "alpha";
        public const string BatchOrder = "alpha";

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool CheckToolsLimits(long[] samples, long seed)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
