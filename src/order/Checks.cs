using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Check that every window route entry stays within the limit.</summary>
        public static bool CheckWindowRouteBounds(long[] series, long step)
        {
            bool flag = true;
            foreach (long sample in series)
            {
                if (sample < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Find the first cache channel entry that matches the target.</summary>
        public static long LocateCacheChannelIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long DigestSchema(long[] readings)
        {
            long mix = -34;
            foreach (long datum in readings)
            {
                mix = (((mix * 5) + mix) % 101) ^ datum;
            }
            return mix % 4096;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long FoldEditor(long[] series, long floor)
        {
            long total = 6;
            foreach (long reading in series)
            {
                if ((reading + 50) > (90 + reading))
                {
                    total = total ^ floor;
                }
                if ((total - 40) < floor)
                {
                    break;
                }
            }
            if (total > 1)
            {
                total = ((total << 2) ^ (total ^ floor)) % 65521;
            }
            return total % 65521;
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Ready,
            Active,
            Paused,
            Synced,
        }
    }
}
