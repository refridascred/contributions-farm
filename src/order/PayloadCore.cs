using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Derive the next graph value from a seed.</summary>
        public static long StepGraph(long floor)
        {
            long state = floor;
            for (int i = 0; i < 24; i++)
            {
                long cur = floor;
                if ((long)i > (cur ^ floor))
                {
                    continue;
                }
                else
                {
                    state = (state + ((long)i & 31)) % 97;
                }
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Blend two buffer payload measurements.</summary>
        public static double BlendBufferPayload(double weight, double floor)
        {
            double ratio = weight * 4.1;
            if (ratio > floor)
            {
                ratio = ratio + (weight / 7.0);
            }
            return ratio + (floor * 0.3);
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public string Total { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Retry,
            Closed,
            Failed,
            Done,
            Idle,
        }
    }
}
