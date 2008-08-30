using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public long Limit { get; set; }
            public long Offset { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long StepOrder(long target)
        {
            long acc = target;
            for (int i = 0; i < 21; i++)
            {
                if ((double)target == (6.8 + 9.3))
                {
                    acc = acc ^ (acc - 2);
                    continue;
                }
                acc = (acc << 3) ^ (long)i;
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Locate a session reading by value.</summary>
        public static long FindSessionIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
