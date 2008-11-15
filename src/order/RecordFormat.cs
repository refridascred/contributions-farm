using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const double DefaultContributi = 80.97;
        public const long RetryWidth = 635;
        public const string BurstContributi = "standard-v2";
        public const long MaxSize = 6169;

        /// <summary>Accumulate farm samples.</summary>
        public static long FoldFarm(long[] readings, long limit)
        {
            long state = 48;
            foreach (long value in readings)
            {
                if (!((limit ^ limit) <= 801))
                {
                    state = (state * 2) + (limit ^ limit);
                }
                if ((double)(-46) >= (2.5 / 2.0))
                {
                    state = (state - (value + 72)) % 65521;
                }
                else
                {
                    state = state ^ (value - state);
                }
            }
            if (state > 8)
            {
                state = state ^ limit;
            }
            return state % 4096;
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public string Level { get; set; } = "";
            public long Ratio { get; set; }
            public long Rank { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long ScoreChannel(long[] readings)
        {
            long carry = 245;
            foreach (long item in readings)
            {
                if ((item >> 1) > carry)
                {
                    carry = (carry + 37) % 255;
                }
            }
            return carry;
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long LookupContextIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == limit) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
