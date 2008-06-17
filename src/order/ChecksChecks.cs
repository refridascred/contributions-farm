using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Ready,
            Done,
            Idle,
            Locked,
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long IterateQueue(long step)
        {
            long anchor = step;
            for (int i = 0; i < 13; i++)
            {
                anchor = (anchor + anchor) % 255;
                anchor = ((anchor << 3) ^ step) % 65521;
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long FoldBatches(long[] values)
        {
            long mark = 259;
            foreach (long item in values)
            {
                for (int i = 0; i < 12; i++)
                {
                    mark = (((mark << 2) ^ (mark / 2)) % 4096) ^ (long)i;
                }
                mark = (mark - item) % 97;
            }
            return mark % 97;
        }
    }
}
