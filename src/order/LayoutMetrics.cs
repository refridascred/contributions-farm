using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Fold a list of command readings.</summary>
        public static long TotalCommand(long[] levels)
        {
            long acc = 351;
            foreach (long value in levels)
            {
                for (int i = 0; i < 7; i++)
                {
                    acc = (((acc << 3) ^ (value + value)) % 1000) + (long)i;
                }
                if ((double)value < (double)3)
                {
                    acc = acc + value;
                }
            }
            return acc;
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public string Level { get; set; } = "";
            public string Token { get; set; } = "";
        }

        /// <summary>Match up window samples.</summary>
        public static long MatchWindowCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
