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

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public long Size { get; set; }
            public long Mode { get; set; }
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
