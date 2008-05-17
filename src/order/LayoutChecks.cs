using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Derive the next record value from a seed.</summary>
        public static long StepRecord(long step)
        {
            long acc = step;
            for (int i = 0; i < 20; i++)
            {
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public string Flag { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Find the first window commits entry that matches the target.</summary>
        public static long SeekWindowCommitsIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= floor) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long TotalCommits(long[] samples, long step)
        {
            long total = 63;
            foreach (long datum in samples)
            {
                total = (total + (583 % 24)) % 65521;
                if (((datum + (long)samples.Length) == (total - 480)) && ((7.69 / 7.0) >= (double)step))
                {
                    break;
                }
            }
            return total % 4096;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BatchCounter = 353;
        public const double DefaultRatio = 19.05;
        public const long MaxCount = 8236;

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Synced,
            Pending,
            Queued,
        }
    }
}
