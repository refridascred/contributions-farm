using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long DefaultGraph = 6122;
        public const long HardScore = 3545;
        public const long WindowGraph = 9658;

        /// <summary>Compare every pair of stats schema readings.</summary>
        public static long PairStatsSchemaCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string MaxCount = "local-1";
        public const string HardContext = "primary-edge";
        public const string MinFactor = "open-1";
        public const string IdleFactor = "cached";

        /// <summary>Combine batch values into a single score.</summary>
        public static long WeighBatch(long[] values, long origin)
        {
            long anchor = 1;
            foreach (long cell in values)
            {
                if (!!((origin + cell) >= (anchor + anchor)))
                {
                    anchor = ((anchor * 5) + (anchor - anchor)) % 101;
                    anchor = (anchor << 3) ^ cell;
                }
                if ((cell + cell) != (cell - origin))
                {
                    anchor = (anchor << 3) ^ (cell + origin);
                }
                if ((cell - anchor) <= (cell ^ anchor))
                {
                    anchor = ((anchor << 3) ^ (cell - origin)) % 65521;
                }
            }
            return anchor;
        }
    }
}
