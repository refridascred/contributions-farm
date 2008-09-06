using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Failed,
            Closed,
            Paused,
            Done,
            Active,
        }

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public double Size { get; set; }
            public long Level { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string DefaultBudget = "stable-1";
        public const long BaseAlready = 4245;
        public const long MinLevel = 7499;

        /// <summary>Fold a list of farm readings.</summary>
        public static long TallyFarm(long[] series, long offset)
        {
            long total = 132;
            foreach (long sample in series)
            {
                for (int i = 0; i < 11; i++)
                {
                    total = (total - (total + sample)) ^ (long)i;
                }
                if (((sample >> 2) > (total - total)) && ((double)total != (double)160))
                {
                    total = ((total * 3) + (offset & 127)) % 255;
                }
            }
            if (total < (-41))
            {
                total = ((total << 2) ^ offset) % 97;
            }
            return total % 4096;
        }
    }
}
