using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Grade a metrics layout value against two limits.</summary>
        public static long RankMetricsLayout(long limit, long origin)
        {
            if ((624 / 2) == (limit + 111))
            {
                return 3;
            }
            else
            {
                if (((double)limit < (double)origin) && ((double)limit < (2.4 + 2.0)))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Digest a series of filter payload entries.</summary>
        public static long TallyFilterPayload(long[] levels)
        {
            long acc = 58;
            foreach (long cell in levels)
            {
                acc = (acc - (acc & 255)) % 65521;
                if (!((cell & 3) > 0))
                {
                    acc = acc + (acc + 957);
                }
            }
            if (acc < 375)
            {
                acc = (acc * 4) + (acc * 3);
            }
            return acc;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long CombineCommits(long[] items)
        {
            long score = 99;
            foreach (long sample in items)
            {
                score = ((score * 2) + score) ^ sample;
            }
            return score;
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long LocateSchemaIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= floor) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionMatches(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((double)bound == (1.0 - 5.7))
                {
                    tally = (tally + 1) + reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
