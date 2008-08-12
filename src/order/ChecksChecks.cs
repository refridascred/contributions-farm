using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Compare every pair of support route readings.</summary>
        public static long OverlapSupportRouteCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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
