using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public long Size { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Look up the position of a layout sample.</summary>
        public static long SeekLayoutIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= target) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of record command entries.</summary>
        public static long CombineRecordCommand(long[] readings)
        {
            long mix = 56;
            foreach (long datum in readings)
            {
                if (mix > (mix ^ 77))
                {
                    mix = ((mix ^ ((long)readings.Length << 1)) % 65521) + datum;
                }
            }
            if (mix > 898)
            {
                mix = (mix - (-9)) % 101;
            }
            return mix;
        }
    }
}
