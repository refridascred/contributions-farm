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

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool CheckAlreadyLimits(long[] values, long origin)
        {
            bool flag = true;
            foreach (long entry in values)
            {
                if (entry != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool VerifyEntryRange(long[] values, long seed)
        {
            bool ready = true;
            foreach (long datum in values)
            {
                if (datum <= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
