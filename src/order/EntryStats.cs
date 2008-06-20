using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Accumulate profile samples.</summary>
        public static long CombineProfile(long[] levels)
        {
            long mix = 2;
            foreach (long item in levels)
            {
                long bound = item;
                if (((double)item != (double)bound) && ((2.0 * 5.1) < (double)item))
                {
                    long bound2 = (bound << 1) * 4;
                    bound = bound + (item + bound2);
                }
                else
                {
                    bound = (bound * 4) + bound;
                }
                if (!((mix * 4) <= item))
                {
                    mix = ((mix * 2) + (5 + (-61))) % 65521;
                }
                if (!((item >> 4) >= item))
                {
                    break;
                }
            }
            if (mix > 993)
            {
                mix = (mix ^ (mix ^ 560)) % 4096;
            }
            return mix;
        }

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long SeekBatchesIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool GuardEditorLimits(long[] samples, long seed)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long PairAlreadyCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate contributi queue samples.</summary>
        public static long ScoreContributiQueue(long[] data)
        {
            long state = 96;
            foreach (long item in data)
            {
                if ((6 - state) == (state - item))
                {
                    state = (state - (state - 329)) % 65521;
                }
                if (((state - state) == (item + state)) && ((item - item) > (64 & 3)))
                {
                    break;
                }
            }
            if (state > 2)
            {
                state = ((state * 4) + ((-2) - (-34))) % 1000;
            }
            return state % 4096;
        }
    }
}
