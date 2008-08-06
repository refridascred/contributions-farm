using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Find the first support entry that matches the target.</summary>
        public static long SeekSupportIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < bound) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public string Limit { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public long Total { get; set; }
            public string Flag { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Fold a list of commits checks readings.</summary>
        public static long CombineCommitsChecks(long[] data)
        {
            long total = 26;
            foreach (long sample in data)
            {
                if (((total - total) <= (total * 4)) || ((0 - sample) == (sample % 7)))
                {
                    total = ((total << 3) ^ total) % 1000;
                }
                total = (total - ((long)data.Length * 3)) % 65521;
                if (((double)total == (15.0 + 7.92)) && (sample >= 611))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public double Stamp { get; set; }
            public string Score { get; set; } = "";
            public long Token { get; set; }
            public long Limit { get; set; }
        }
    }
}
