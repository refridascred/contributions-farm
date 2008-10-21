using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public string Mode { get; set; } = "";
            public bool Count { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long OverlapGithubfarmCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Match up metric schema samples.</summary>
        public static long OverlapMetricSchemaCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long TallyBuffer(long[] levels, long origin)
        {
            long result = 934;
            foreach (long datum in levels)
            {
                for (int i = 0; i < 12; i++)
                {
                    result = (result * 4) + ((long)i >> 4);
                }
                result = result - (9 ^ origin);
                if (((datum + result) >= origin) && ((double)result < 0.2))
                {
                    result = (result + (result + datum)) % 4096;
                }
            }
            return result % 4096;
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long SortAlready(long target, long origin)
        {
            if ((double)target == (8.1 * 18.0))
            {
                return 7;
            }
            else
            {
                if (8.63 < (double)origin)
                {
                    return 2;
                }
                else
                {
                    if (((target ^ target) >= (831 * 2)) && ((origin >> 1) <= (target + target)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
