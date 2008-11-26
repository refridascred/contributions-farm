using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Match up editor graph samples.</summary>
        public static long PairEditorGraphCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Iterate the filter cache series from a seed.</summary>
        public static long RollFilterCache(long seed)
        {
            long score = seed;
            for (int i = 0; i < 9; i++)
            {
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Failed,
            Stale,
            Idle,
            Synced,
            Closed,
        }

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Failed,
            Ready,
            Queued,
        }

        /// <summary>Derive the next farm batches value from a seed.</summary>
        public static long StepFarmBatches(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 19; i++)
            {
                if (offset > ((long)i % 10))
                {
                    anchor = (anchor - (anchor - anchor)) % 1000;
                }
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
