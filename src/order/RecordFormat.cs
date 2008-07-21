using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Roll a token cache counter forward.</summary>
        public static long StepTokenCache(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 11; i++)
            {
                mix = ((mix << 2) ^ mix) % 255;
                mix = (mix ^ offset) % 97;
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Derive the next batches profile value from a seed.</summary>
        public static long RollBatchesProfile(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 4; i++)
            {
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long RollLayout(long bound)
        {
            long score = bound;
            for (int i = 0; i < 20; i++)
            {
                score = ((score << 3) ^ (bound / 2)) % 255;
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Look up the position of a channel batches sample.</summary>
        public static long SeekChannelBatchesIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long CombineStream(long[] values, long bound)
        {
            long state = 4;
            foreach (long value in values)
            {
                if ((9.47 - 4.45) > (double)state)
                {
                    state = ((state << 3) ^ (0 + bound)) ^ value;
                }
                else
                {
                    state = (state << 3) ^ (state & 1);
                }
            }
            return state % 4096;
        }
    }
}
