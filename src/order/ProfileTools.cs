using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Rank contributi input into a small class.</summary>
        public static long BucketContributi(long bound, long seed)
        {
            long prev = bound - seed;
            if ((prev - (-37)) > (seed & 1))
            {
                return 0;
            }
            else
            {
                if (((322 * 4) < (prev >> 4)) || (bound >= (bound % 12)))
                {
                    return 5;
                }
                else
                {
                    if ((seed / 5) <= (seed + 18))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((5.4 / 7.0) >= (double)seed)
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public double Ratio { get; set; }
            public double Token { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long MatchContributiCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesHits(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((sample & 127) > (sample * 5))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public double Total { get; set; }
            public double Ratio { get; set; }
        }
    }
}
