using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Closed,
            Queued,
            Paused,
            Locked,
            Ready,
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Closed,
            Retry,
            Active,
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long StepPayload(long target)
        {
            long acc = target;
            for (int i = 0; i < 14; i++)
            {
                if (!((target + target) != (84 + acc)))
                {
                    acc = (acc * 5) + (target % 12);
                }
                if ((double)target <= 5.52)
                {
                    acc = ((acc << 3) ^ ((long)i ^ target)) % 4096;
                    break;
                }
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
