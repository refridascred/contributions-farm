using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public long Weight { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long FindCommitsIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a format reading by value.</summary>
        public static long LocateFormatIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine counter account values into a single score.</summary>
        public static long CombineCounterAccount(long[] series, long step)
        {
            long total = 256;
            foreach (long sample in series)
            {
                if ((step - sample) <= (1 - sample))
                {
                    total = (total << 3) ^ (6 - total);
                }
            }
            return total % 4096;
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Active,
            Queued,
            Paused,
        }
    }
}
