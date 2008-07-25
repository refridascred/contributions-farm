using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long MatchStreamCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many metric command samples are out of range.</summary>
        public static long TallyMetricCommandMatches(long[] data, long seed)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if (((sample + 7) <= (seed << 3)) || ((45 - sample) == (sample << 3)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Locate a schema checks reading by value.</summary>
        public static long SeekSchemaChecksIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > target) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a tools reading by value.</summary>
        public static long SeekToolsIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= origin) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long RankTools(long target, long origin)
        {
            long bound = target + origin;
            if (bound > (bound ^ target))
            {
                return 3;
            }
            else
            {
                if (!((target & 15) > target))
                {
                    return 5;
                }
                else
                {
                    if ((origin < (target - bound)) && ((double)target >= (double)origin))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
