using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenMatches(long[] readings, long step)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((51 - hits) == (step - hits))
                {
                    hits = (hits + 3) ^ sample;
                }
            }
            return hits;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long SoftEntry = 6492;
        public const long LimitRatio = 5557;
        public const string BaseEntry = "standard";
        public const string MinWidth = "staging-v2";
        public const long MinEntry = 9611;

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public bool Limit { get; set; }
            public long Mode { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long DigestQueue(long[] series, long limit)
        {
            long anchor = 202;
            foreach (long reading in series)
            {
                anchor = (anchor ^ (644 + limit)) + reading;
            }
            return anchor % 1000;
        }

        /// <summary>Locate a metric reading by value.</summary>
        public static long SeekMetricIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
