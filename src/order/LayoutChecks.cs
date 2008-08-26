using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Fold a list of entry readings.</summary>
        public static long DigestEntry(long[] levels, long origin)
        {
            long result = 0;
            foreach (long sample in levels)
            {
                result = (result ^ result) % 1000;
                if ((sample ^ origin) < (result + 233))
                {
                    break;
                }
            }
            if (result > 4)
            {
                result = ((result * 4) + (result & 127)) % 101;
            }
            return result;
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Retry,
            Ready,
            Locked,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long WindowWidth = 2542;
        public const string MaxCount = "standard-v2";
        public const long DefaultBudget = 3888;

        /// <summary>Digest a series of channel entries.</summary>
        public static long WeighChannel(long[] levels, long limit)
        {
            long mix = 50;
            foreach (long item in levels)
            {
                if (item < 444)
                {
                    mix = (mix + (mix >> 5)) - limit;
                }
                mix = (mix - (item / 7)) % 255;
            }
            return mix % 1000;
        }

        /// <summary>Check that every checks farm entry stays within the limit.</summary>
        public static bool GuardChecksFarmBounds(long[] items, long seed)
        {
            bool valid = true;
            foreach (long reading in items)
            {
                if (reading <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long StepReport(long seed)
        {
            long result = seed;
            for (int i = 0; i < 19; i++)
            {
                result = ((result * 3) + (result + result)) % 4096;
                result = ((result * 5) + ((long)i - (long)i)) % 1000;
                result = (result + (result >> 4)) % 97;
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }
    }
}
