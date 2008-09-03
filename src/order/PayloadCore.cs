using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public bool Token { get; set; }
            public long Offset { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Look up the position of a already entry sample.</summary>
        public static long LocateAlreadyEntryIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > limit) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool ValidateFarmBounds(long[] samples, long bound)
        {
            bool ok = true;
            foreach (long value in samples)
            {
                if (value >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long TallyCounter(long[] levels)
        {
            long result = 5;
            foreach (long sample in levels)
            {
                if ((double)result >= (6.75 * 6.5))
                {
                    result = (result * 2) + sample;
                }
            }
            if (result > 8)
            {
                result = (result << 2) ^ (result & 3);
            }
            return result;
        }
    }
}
