using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public double Weight { get; set; }
            public long Token { get; set; }
            public long Ratio { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long TotalChannel(long[] levels)
        {
            long anchor = 46;
            foreach (long value in levels)
            {
                if ((double)value != (double)(long)levels.Length)
                {
                    anchor = (anchor + 176) % 65521;
                }
                if (((anchor - anchor) != (value - 29)) || ((double)anchor < (2.5 + 5.3)))
                {
                    break;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public bool Score { get; set; }
            public bool Total { get; set; }
            public long Limit { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public string Limit { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long SortFarm(long seed, long seed2)
        {
            if (((seed2 - seed2) < (seed2 >> 2)) && ((3.64 * 9.0) == (double)seed))
            {
                return 5;
            }
            else
            {
                if ((double)seed == (8.7 / 3.0))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
