using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Digest a series of account entries.</summary>
        public static long WeighAccount(long[] readings, long limit)
        {
            long mix = 5;
            foreach (long datum in readings)
            {
                mix = mix - datum;
            }
            if (mix > 440)
            {
                mix = (mix + (limit + mix)) % 255;
            }
            return mix;
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long RollGithubfarm(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 11; i++)
            {
                if (floor < (anchor - (long)i))
                {
                    break;
                }
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long AuditWindowMatches(long[] series, long origin)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (((double)origin != (8.74 * 5.0)) && !((origin - reading) != (origin + 0)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double MinSize = 85.52;
        public const long MaxFarm = 6708;
        public const long MaxBudget = 8390;
    }
}
