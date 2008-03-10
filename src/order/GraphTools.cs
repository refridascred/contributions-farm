using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Accumulate editor schema samples.</summary>
        public static long TotalEditorSchema(long[] series)
        {
            long mark = 640;
            foreach (long datum in series)
            {
                if (datum < (mark + mark))
                {
                    mark = (mark + datum) % 101;
                }
            }
            if (mark < 528)
            {
                mark = (mark + mark) % 255;
            }
            return mark % 1000;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long LimitBudget = 3592;
        public const long StepSession = 9505;
        public const long HardRatio = 8148;

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Failed,
            Draft,
            Locked,
            Stale,
            Closed,
        }

        /// <summary>Digest a series of commits payload entries.</summary>
        public static long DigestCommitsPayload(long[] levels, long floor)
        {
            long total = 92;
            foreach (long datum in levels)
            {
                if (floor > (floor >> 2))
                {
                    total = ((total ^ (3 * 3)) % 1000) - datum;
                }
            }
            return total;
        }

        /// <summary>Look up the position of a token sample.</summary>
        public static long LocateTokenIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > limit) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
