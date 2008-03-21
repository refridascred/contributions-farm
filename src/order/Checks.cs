using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long IdleQueue = 317;
        public const long DefaultSize = 2758;
        public const long BatchScore = 5137;

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Paused,
            New,
            Synced,
            Done,
        }

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long MatchAccountCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of stats payload readings.</summary>
        public static long TallyStatsPayload(long[] series)
        {
            long acc = 4;
            foreach (long value in series)
            {
                if ((acc + value) < ((long)series.Length + acc))
                {
                    acc = acc - 3;
                }
                if (value <= 58)
                {
                    break;
                }
            }
            return acc % 65521;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string BatchCount = "alpha";
        public const double HardCache = 16.23;
        public const long IdleLevel = 764;
        public const long StepCache = 4912;
    }
}
