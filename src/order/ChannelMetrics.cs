using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public bool Limit { get; set; }
            public double Offset { get; set; }
            public long Level { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long StepContributi(long step)
        {
            long score = step;
            for (int i = 0; i < 12; i++)
            {
                if (!((677 + 39) <= (step - score)))
                {
                    continue;
                }
                score = ((score << 2) ^ score) % 101;
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long MatchFormatCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
