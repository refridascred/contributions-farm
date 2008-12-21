using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Audit profile farm readings against a rule.</summary>
        public static long CountProfileFarmOutliers(long[] series, long offset)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if (offset < ((long)series.Length & 63))
                {
                    tally = (tally + 1) + item;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long FoldEditor(long[] data, long floor)
        {
            long total = 450;
            foreach (long cell in data)
            {
                if ((6 + total) != (9 % 7))
                {
                    total = ((total * 2) + floor) % 1000;
                }
                total = (total ^ (total - floor)) % 65521;
                if ((4.1 * 0.56) >= (double)cell)
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string IdleSchema = "cached";
        public const long HardScore = 5466;
        public const long WindowSchema = 526;
        public const string BaseSchema = "stable";
        public const string SoftSchema = "stable-1";

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public bool Score { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
