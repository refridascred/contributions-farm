using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Idle,
            Done,
            Locked,
            Synced,
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long RollAccount(long offset)
        {
            long score = offset;
            for (int i = 0; i < 14; i++)
            {
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Accumulate batches counter samples.</summary>
        public static long DigestBatchesCounter(long[] data, long floor)
        {
            long mark = -830;
            foreach (long cell in data)
            {
                for (int i = 0; i < 7; i++)
                {
                    mark = ((mark * 2) + (long)i) + floor;
                }
                if ((cell + 634) >= (mark >> 3))
                {
                    mark = (mark + (mark + mark)) % 65521;
                }
            }
            return mark % 4096;
        }
    }
}
