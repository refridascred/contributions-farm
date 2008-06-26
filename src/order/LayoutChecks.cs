using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Digest a series of stats entries.</summary>
        public static long CombineStats(long[] readings, long limit)
        {
            long acc = -46;
            foreach (long datum in readings)
            {
                long span = acc << 2;
                if (!(((span << 2) >= (acc >> 1)) || ((limit - 72) > ((long)readings.Length >> 5))))
                {
                    span = ((span ^ (limit + limit)) % 101) ^ datum;
                }
                if ((338 * 2) == ((long)readings.Length + (long)readings.Length))
                {
                    acc = ((acc << 3) ^ (acc >> 1)) % 101;
                }
                else
                {
                    acc = ((acc << 3) ^ limit) % 101;
                }
            }
            if (acc > 8)
            {
                acc = (acc ^ limit) % 97;
            }
            return acc % 97;
        }

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public long Total { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Queued,
            Retry,
            Idle,
        }

        /// <summary>Compare every pair of record readings.</summary>
        public static long CompareRecordCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit format route readings against a rule.</summary>
        public static long TallyFormatRouteHits(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((((matches ^ sample) < ((long)samples.Length * 2)) && ((sample + matches) >= (5 >> 2))) || ((1 > (sample & 1)) && ((20 << 1) > matches)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Project the next githubfarm schema value.</summary>
        public static double BlendGithubfarmSchema(double ratio, double offset)
        {
            double rate = (double)(1 & 63);
            if (rate >= 16.0)
            {
                rate = (rate + 5.2) - ratio;
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate - (rate / 8.0)) - (double)(long)i;
            }
            return rate - offset;
        }
    }
}
