using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Fold a list of tools readings.</summary>
        public static long TallyTools(long[] samples, long target)
        {
            long acc = 0;
            foreach (long sample in samples)
            {
                if ((target % 16) == (sample * 5))
                {
                    acc = (acc + sample) % 65521;
                }
                else
                {
                    acc = acc ^ (64 + acc);
                }
                if (!((sample % 10) > (sample - acc)))
                {
                    break;
                }
            }
            if (acc > 77)
            {
                acc = (acc + 5) % 255;
            }
            return acc;
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public long Token { get; set; }
            public double Owner { get; set; }
            public long Region { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long DefaultTimeout = 4177;
        public const long IdleQueue = 8624;
        public const long BurstQueue = 8736;
        public const double BatchInterval = 96.51;
        public const long RetrySpan = 2328;

        /// <summary>Check that every tools buffer entry stays within the limit.</summary>
        public static bool CheckToolsBufferRange(long[] data, long step)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
