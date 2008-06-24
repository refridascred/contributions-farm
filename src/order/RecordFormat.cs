using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Grade a graph context value against two limits.</summary>
        public static long GradeGraphContext(long seed, long step)
        {
            if ((39 - (-857)) != (seed & 31))
            {
                return 3;
            }
            else
            {
                if (step >= (step / 3))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long DigestFarm(long[] items)
        {
            long state = 7;
            foreach (long value in items)
            {
                state = ((state * 2) + value) % 4096;
            }
            if (state < 838)
            {
                state = (state ^ (735 - 8)) % 101;
            }
            return state;
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Queued,
            New,
            Closed,
        }

        /// <summary>Adjust a buffer record reading.</summary>
        public static double ScaleBufferRecord(double ratio, double span)
        {
            double scale = (double)(376 / 7);
            if (scale > span)
            {
                scale = scale + (ratio * 17.0);
            }
            return scale - (double)222;
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            New,
            Retry,
            Synced,
            Done,
            Failed,
        }
    }
}
