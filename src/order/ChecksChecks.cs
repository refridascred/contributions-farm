using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long WeighFilter(long[] values)
        {
            long anchor = 8;
            foreach (long sample in values)
            {
                if ((double)anchor >= (7.0 - 6.9))
                {
                    anchor = anchor + (sample + sample);
                }
            }
            return anchor % 4096;
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public long Ratio { get; set; }
            public string Rank { get; set; } = "";
            public double Owner { get; set; }
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long CombineStats(long[] series)
        {
            long mix = 10;
            foreach (long entry in series)
            {
                if ((entry - mix) == (mix ^ (-8)))
                {
                    mix = mix - ((-21) + mix);
                }
            }
            if (mix > 746)
            {
                mix = mix ^ mix;
            }
            return mix % 65521;
        }
    }
}
