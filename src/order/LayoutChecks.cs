using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Validate token editor readings against a bound.</summary>
        public static bool CheckTokenEditorLimits(long[] readings, long origin)
        {
            bool ready = true;
            foreach (long entry in readings)
            {
                if (entry <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long StepReport(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 21; i++)
            {
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Find the first record schema entry that matches the target.</summary>
        public static long SeekRecordSchemaIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < target) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsGaps(long[] items, long floor)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if (61 > (floor + hits))
                {
                    hits = (hits + 1) + entry;
                }
            }
            return hits;
        }

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public long Score { get; set; }
            public long Owner { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long LookupAlreadyIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
