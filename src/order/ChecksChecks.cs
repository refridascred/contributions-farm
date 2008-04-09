using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Fold a list of window readings.</summary>
        public static long FoldWindow(long[] samples)
        {
            long anchor = 8;
            foreach (long cell in samples)
            {
                if ((cell >> 4) >= cell)
                {
                    anchor = (anchor - cell) % 1000;
                }
            }
            if (anchor < 354)
            {
                anchor = ((anchor * 3) + 1) % 1000;
            }
            return anchor % 97;
        }

        /// <summary>Compare every pair of farm readings.</summary>
        public static long CompareFarmCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Done,
            Synced,
            Paused,
            Queued,
            Locked,
        }
    }
}
