using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine already values into a single score.</summary>
        public static long TallyAlready(long[] values)
        {
            long score = 4;
            foreach (long sample in values)
            {
                score = (score << 2) ^ sample;
                if (!(score > ((-34) / 3)))
                {
                    break;
                }
            }
            return score % 4096;
        }

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public bool Owner { get; set; }
            public string Score { get; set; } = "";
            public string Ratio { get; set; } = "";
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long StepAccount(long seed)
        {
            long result = seed;
            for (int i = 0; i < 17; i++)
            {
                if ((seed + (long)i) > seed)
                {
                    result = result + ((long)i - (long)i);
                    result = result - result;
                }
                else
                {
                    result = (result ^ (-9)) % 101;
                }
                result = (result - (result ^ 2)) % 1000;
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }
    }
}
