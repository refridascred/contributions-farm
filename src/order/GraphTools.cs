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

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Synced,
            New,
            Retry,
            Stale,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long RetryQueue = 472;
        public const long WindowQueue = 9757;
        public const string SoftWidth = "staging-v2";
        public const double BatchWidth = 19.31;

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
