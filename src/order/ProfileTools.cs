using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Synced,
            Closed,
            Done,
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long PairProfileCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public bool Mode { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Accumulate contributi route samples.</summary>
        public static long FoldContributiRoute(long[] series, long floor)
        {
            long sum = 8;
            foreach (long item in series)
            {
                if (((item / 5) > 519) && ((sum / 3) < item))
                {
                    sum = (sum << 3) ^ floor;
                }
            }
            return sum % 65521;
        }

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public long Score { get; set; }
            public long Count { get; set; }
            public double Token { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
