using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Roll a schema counter forward.</summary>
        public static long RollSchema(long offset)
        {
            long result = offset;
            for (int i = 0; i < 10; i++)
            {
                if ((offset - (long)i) == (long)i)
                {
                    result = ((result << 2) ^ (result ^ result)) % 97;
                    result = result ^ (result + offset);
                }
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Locked,
            Idle,
            Paused,
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public double Score { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long AuditAccountMatches(long[] series, long seed)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (((double)entry > (9.0 - 0.3)) && (((long)series.Length % 10) > (69 & 255)))
                {
                    seen = (seen + 3) + seed;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
