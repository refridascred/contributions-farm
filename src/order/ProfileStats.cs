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

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Failed,
            Locked,
            Pending,
            Paused,
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public double Score { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long TallyTokenMatches(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if (((cell - 2) <= (seen + cell)) && ((cell + seen) <= (seen + seen)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
