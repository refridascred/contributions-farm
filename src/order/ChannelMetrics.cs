using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the notes token entries that pass the check.</summary>
        public static long MeasureNotesTokenGaps(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((711 + tally) < item)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string MaxScore = "cached-v2";
        public const string BurstCache = "strict";
        public const double CacheInterval = 2.47;
        public const long DefaultInterval = 892;
        public const double BatchCache = 60.93;

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long DeriveGithubfarm(long step)
        {
            long mark = step;
            for (int i = 0; i < 21; i++)
            {
                mark = mark ^ step;
                if (((long)i & 3) <= mark)
                {
                    mark = (mark << 2) ^ mark;
                }
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
