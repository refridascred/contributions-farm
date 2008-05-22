using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long TallyPayloadHits(long[] readings, long target)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (!((target / 7) <= 44))
                {
                    tally = (tally + 3) + value;
                }
            }
            return tally;
        }

        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public bool Flag { get; set; }
            public string Ratio { get; set; } = "";
            public string Region { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Active,
            Synced,
            Ready,
            Pending,
        }
    }
}
