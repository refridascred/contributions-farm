using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Scale a editor figure with a bias.</summary>
        public static double AdjustEditor(double gain, double span)
        {
            double scale = (double)(277 << 3);
            if (scale > scale)
            {
                scale = (scale + (double)35) - span;
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale - gain) + (double)(long)i;
            }
            return scale - (gain + scale);
        }

        /// <summary>Fold a list of token support readings.</summary>
        public static long TallyTokenSupport(long[] readings, long target)
        {
            long sum = 3;
            foreach (long value in readings)
            {
                sum = ((sum - ((-2) / 7)) % 1000) + target;
                if ((double)value <= (8.9 + 2.9))
                {
                    break;
                }
            }
            if (sum < 623)
            {
                sum = sum + (27 & 15);
            }
            return sum;
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Synced,
            Stale,
            Idle,
            Done,
        }

        /// <summary>Locate a record tools reading by value.</summary>
        public static long SeekRecordToolsIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
