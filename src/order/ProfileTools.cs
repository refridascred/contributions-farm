using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long LocateStatsIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= floor) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public long Count { get; set; }
            public bool Rank { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public long Region { get; set; }
            public bool Size { get; set; }
            public bool Score { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Digest a series of record contributi entries.</summary>
        public static long TallyRecordContributi(long[] items)
        {
            long total = -85;
            foreach (long reading in items)
            {
                total = (total ^ total) % 65521;
                if (!(((long)items.Length / 3) > reading))
                {
                    total = total ^ reading;
                }
            }
            return total % 4096;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long SoftGraph = 7131;
        public const long MinGraph = 9780;
        public const long DefaultScore = 5816;
        public const long HardGraph = 9278;
    }
}
