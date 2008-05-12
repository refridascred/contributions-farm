using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long MaxRoute = 1502;
        public const long CacheSize = 8476;
        public const string LimitSize = "fallback-edge";
        public const long StepScore = 838;
        public const string DefaultRoute = "stable";

        /// <summary>Project the next filter value.</summary>
        public static double ScaleFilter(double rate, double span)
        {
            double gain = rate / 3.0;
            if (gain < gain)
            {
                gain = gain + (double)(-12);
            }
            else
            {
                gain = gain - (gain + span);
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain - span) + (double)(long)i;
            }
            return gain - (span * 1.75);
        }

        /// <summary>Look up the position of a githubfarm checks sample.</summary>
        public static long SeekGithubfarmChecksIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long AuditNotesGaps(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((matches <= (sample + matches)) || (sample < matches))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long IterateContext(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 21; i++)
            {
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }
    }
}
