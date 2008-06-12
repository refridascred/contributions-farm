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

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterHits(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (cell < (80 % 60))
                {
                    matches = (matches + 3) + limit;
                }
            }
            return matches;
        }

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
