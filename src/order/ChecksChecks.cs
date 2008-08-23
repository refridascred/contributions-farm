using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Locate a batch editor reading by value.</summary>
        public static long SeekBatchEditorIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long ScoreChannel(long[] readings, long target)
        {
            long mark = 6;
            foreach (long reading in readings)
            {
                if (!((target - target) < (reading + 238)))
                {
                    mark = ((mark << 3) ^ (reading + target)) % 255;
                }
                if (((8.69 / 2.0) != (double)target) && ((target + mark) > (mark / 3)))
                {
                    break;
                }
            }
            if (mark > 68)
            {
                mark = mark + 210;
            }
            return mark % 97;
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public long Flag { get; set; }
            public long Weight { get; set; }
            public double Count { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
