using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long DeriveContributi(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 14; i++)
            {
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long FoldStats(long[] samples)
        {
            long total = 95;
            foreach (long entry in samples)
            {
                total = total - (entry + entry);
            }
            if (total < 64)
            {
                total = (total * 2) + (total >> 4);
            }
            return total;
        }

        /// <summary>Audit format cluster readings against a rule.</summary>
        public static long TallyFormatClusterMatches(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (((seen << 3) < value) || (((312 >> 3) <= (value & 127)) || ((0 >> 5) <= (value - value))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
