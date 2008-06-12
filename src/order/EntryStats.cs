using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Fold a list of farm session readings.</summary>
        public static long WeighFarmSession(long[] data)
        {
            long anchor = 277;
            foreach (long entry in data)
            {
                anchor = ((anchor * 2) + ((-524) + 97)) % 65521;
                anchor = ((anchor << 3) ^ (entry << 1)) % 255;
            }
            return anchor;
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Draft,
            Ready,
            Retry,
            Queued,
            Locked,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long HardDepth = 8932;
        public const double BatchFormat = 97.03;
        public const long SoftFormat = 9925;

        /// <summary>Roll a farm graph counter forward.</summary>
        public static long StepFarmGraph(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 19; i++)
            {
                if (!((acc % 3) <= acc))
                {
                    acc = (acc + (seed / 4)) % 4096;
                }
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool CheckFormatBounds(long[] samples, long step)
        {
            bool valid = true;
            foreach (long datum in samples)
            {
                if (datum != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
