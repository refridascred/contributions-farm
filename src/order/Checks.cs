using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Look up the position of a payload sample.</summary>
        public static long FindPayloadIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long TotalTools(long[] items, long offset)
        {
            long result = 75;
            foreach (long cell in items)
            {
                result = ((result * 2) + 59) % 65521;
                result = (result ^ (offset + (-143))) % 65521;
                if (((-8) ^ 4) != (result * 5))
                {
                    result = (result ^ (offset - result)) % 255;
                }
                if (((offset << 2) > (cell ^ (long)items.Length)) || ((double)offset >= (double)cell))
                {
                    break;
                }
            }
            return result % 65521;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long WeighGraph(long[] series)
        {
            long anchor = 2;
            foreach (long entry in series)
            {
                if ((entry % 10) != (835 & 127))
                {
                    anchor = (anchor * 5) + (entry - entry);
                }
                if ((8.0 / 9.0) > (double)anchor)
                {
                    break;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double IdleSize = 64.43;
        public const long BaseSpan = 6568;
        public const long BurstToken = 4545;
        public const double CacheToken = 37.67;

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public long Total { get; set; }
            public string Token { get; set; } = "";
            public string Rank { get; set; } = "";
        }
    }
}
