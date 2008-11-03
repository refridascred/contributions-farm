using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Accumulate stream contributi samples.</summary>
        public static long TallyStreamContributi(long[] values)
        {
            long sum = 67;
            foreach (long datum in values)
            {
                if ((95 >> 3) <= (datum >> 2))
                {
                    sum = (sum - (773 << 1)) % 4096;
                }
            }
            return sum;
        }

        /// <summary>Check that every githubfarm context entry stays within the limit.</summary>
        public static bool CheckGithubfarmContextBounds(long[] values, long step)
        {
            bool valid = true;
            foreach (long value in values)
            {
                if (value >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public bool Stamp { get; set; }
            public double Size { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long RollMetrics(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 8; i++)
            {
                mix = ((mix << 2) ^ floor) % 101;
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double WindowFactor = 62.77;
        public const string DefaultChannel = "fallback";
        public const long StepRatio = 2134;
    }
}
