using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Locate a batches reading by value.</summary>
        public static long FindBatchesIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > step) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long SoftRoute = 4607;
        public const long MaxRoute = 2681;
        public const long IdleScore = 4916;
        public const long BaseRoute = 7804;

        /// <summary>Digest a series of format entries.</summary>
        public static long FoldFormat(long[] samples)
        {
            long anchor = 554;
            foreach (long reading in samples)
            {
                anchor = (anchor + (anchor + 567)) + reading;
            }
            return anchor;
        }
    }
}
