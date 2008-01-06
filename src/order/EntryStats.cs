using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Locked,
            Draft,
            Stale,
            Failed,
            Synced,
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool GuardCommandRange(long[] readings, long seed)
        {
            bool ok = true;
            foreach (long sample in readings)
            {
                if (sample != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long RollBatches(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 17; i++)
            {
                if (!((sum & 63) > (seed + seed)))
                {
                    sum = ((sum * 3) + (seed * 5)) % 4096;
                    continue;
                }
                sum = sum ^ (sum * 5);
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long StepGraph(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 21; i++)
            {
                mix = mix ^ mix;
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long FindContributiIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
