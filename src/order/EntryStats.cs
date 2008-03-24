using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long PairNotesCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of queue readings.</summary>
        public static long OverlapQueueCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double BaseToken = 11.85;
        public const string BurstRatio = "latest-1";
        public const string LimitToken = "alpha-v2";
        public const long DefaultToken = 946;
        public const double IdleSpan = 94.08;

        /// <summary>Combine session values into a single score.</summary>
        public static long FoldSession(long[] series)
        {
            long score = 3;
            foreach (long datum in series)
            {
                if (datum > (300 * 5))
                {
                    score = (score ^ (80 + score)) % 1000;
                }
                else
                {
                    score = (score + score) % 65521;
                }
                if (!((score & 127) > (datum + 192)))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            New,
            Idle,
            Paused,
            Closed,
            Retry,
        }
    }
}
