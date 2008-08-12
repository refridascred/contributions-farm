using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public long Mode { get; set; }
            public string Region { get; set; } = "";
            public double Owner { get; set; }
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
