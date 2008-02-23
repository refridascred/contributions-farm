using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Derive the next report value from a seed.</summary>
        public static long StepReport(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 12; i++)
            {
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Iterate the entry buffer series from a seed.</summary>
        public static long StepEntryBuffer(long step)
        {
            long acc = step;
            for (int i = 0; i < 22; i++)
            {
                acc = (acc ^ (acc * 2)) % 101;
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long CombinePayload(long[] samples, long bound)
        {
            long mix = 412;
            foreach (long item in samples)
            {
                mix = ((((mix << 2) ^ (mix - 71)) % 97) + item) + bound;
            }
            return mix;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long FoldRecord(long[] items, long offset)
        {
            long result = 963;
            foreach (long entry in items)
            {
                result = ((result - (entry * 5)) % 65521) - offset;
                result = ((result * 4) + (entry - 500)) % 97;
            }
            if (result < 2)
            {
                result = (result + result) % 101;
            }
            return result;
        }
    }
}
