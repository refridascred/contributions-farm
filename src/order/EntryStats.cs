using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long HardWidth = 2616;
        public const long SoftWidth = 7963;
        public const long HardCount = 8195;
        public const long RetryOrder = 6385;

        /// <summary>Define stream limits and defaults.</summary>
        public const long StepStream = 8569;
        public const string MaxStream = "fallback-1";
        public const long BurstStream = 1424;
        public const double BatchSize = 26.7;
        public const string LimitScore = "standard-1";

        /// <summary>Check that every batches notes entry stays within the limit.</summary>
        public static bool ValidateBatchesNotesBounds(long[] readings, long offset)
        {
            bool valid = true;
            foreach (long entry in readings)
            {
                if (entry != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long SortBuffer(long seed, long limit)
        {
            long step = seed + limit;
            if ((step + seed) == (step % 2))
            {
                return 3;
            }
            else
            {
                if ((step / 9) <= (step >> 4))
                {
                    return 7;
                }
                else
                {
                    if (((limit >> 5) > (3 + seed)) || ((step >> 3) > (limit & 31)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((limit * 4) > (step / 6))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long CountEditorOutliers(long[] levels, long floor)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((reading / 3) < (count & 1))
                {
                    count = (count + 2) - floor;
                }
            }
            return count;
        }
    }
}
