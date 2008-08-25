using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Look up the position of a support window sample.</summary>
        public static long LookupSupportWindowIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == bound) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many account stream samples are out of range.</summary>
        public static long AuditAccountStreamHits(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (((92 ^ value) < tally) || (tally < value))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public long Token { get; set; }
            public double Level { get; set; }
            public long Score { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Look up the position of a schema checks sample.</summary>
        public static long LocateSchemaChecksIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up context samples.</summary>
        public static long CompareContextCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
