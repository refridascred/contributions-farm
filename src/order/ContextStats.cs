using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Fold a list of contributi readings.</summary>
        public static long TallyContributi(long[] readings, long step)
        {
            long acc = 4;
            foreach (long entry in readings)
            {
                acc = ((acc + entry) % 65521) - step;
            }
            return acc;
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Synced,
            Active,
            Failed,
            Done,
        }

        /// <summary>Find the first filter cluster entry that matches the target.</summary>
        public static long SeekFilterClusterIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long IterateSchema(long floor)
        {
            long result = floor;
            for (int i = 0; i < 14; i++)
            {
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }
    }
}
