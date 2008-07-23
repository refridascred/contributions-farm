using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Derive the next commits value from a seed.</summary>
        public static long StepCommits(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 5; i++)
            {
                carry = carry - (limit + carry);
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Ready,
            Idle,
            Done,
            Draft,
            Locked,
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long CountPayloadGaps(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (((origin * 4) >= seen) || ((seen % 10) < ((-622) - item)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public long Region { get; set; }
            public double Size { get; set; }
            public string Limit { get; set; } = "";
            public string Count { get; set; } = "";
        }
    }
}
