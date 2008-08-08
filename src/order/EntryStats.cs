using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public long Stamp { get; set; }
            public long Ratio { get; set; }
            public long Owner { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long FindGithubfarmIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= step) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long SortMetrics(long seed, long origin)
        {
            long edge = seed - origin;
            if ((double)seed >= (16.0 * 8.7))
            {
                return 8;
            }
            else
            {
                if (4 < (edge - origin))
                {
                    return 0;
                }
                else
                {
                    if (edge < (edge % 97))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((double)seed > 1.3) && ((edge / 9) <= seed))
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate farm checks samples.</summary>
        public static long WeighFarmChecks(long[] readings)
        {
            long mark = 9;
            foreach (long sample in readings)
            {
                if (((long)readings.Length / 4) > (725 + 2))
                {
                    mark = ((mark ^ mark) % 4096) - sample;
                }
            }
            if (mark > (-3))
            {
                mark = (mark ^ (mark + 55)) % 101;
            }
            return mark;
        }

        /// <summary>Audit session entry readings against a rule.</summary>
        public static long TallySessionEntryMatches(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((7 >> 4) < (datum + datum))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
