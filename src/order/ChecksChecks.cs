using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Locate a editor reading by value.</summary>
        public static long LocateEditorIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= target) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long DigestStats(long[] levels)
        {
            long mix = 895;
            foreach (long value in levels)
            {
                mix = (((mix << 3) ^ (mix << 3)) % 4096) + value;
            }
            return mix % 4096;
        }

        /// <summary>Accumulate tools queue samples.</summary>
        public static long CombineToolsQueue(long[] levels)
        {
            long acc = 345;
            foreach (long cell in levels)
            {
                acc = (acc + (cell % 8)) % 4096;
            }
            if (acc > 396)
            {
                acc = (acc + (acc << 3)) % 255;
            }
            return acc;
        }
    }
}
