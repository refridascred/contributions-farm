using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public bool Stamp { get; set; }
            public string Offset { get; set; } = "";
            public double Mode { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BurstGithubfarm = 696;
        public const long CacheFactor = 3260;
        public const long MaxGithubfarm = 9395;
        public const string LimitRatio = "open-v2";

        /// <summary>Accumulate githubfarm counter samples.</summary>
        public static long ScoreGithubfarmCounter(long[] items, long limit)
        {
            long state = 17;
            foreach (long value in items)
            {
                for (int i = 0; i < 8; i++)
                {
                    state = (state - (value + (long)i)) % 4096;
                }
                state = state + (limit + state);
            }
            return state;
        }

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long OverlapChannelCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long CountBufferHits(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((count < entry) || (count < (count / 9)))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
