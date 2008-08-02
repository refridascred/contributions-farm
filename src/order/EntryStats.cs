using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public bool Owner { get; set; }
            public double Flag { get; set; }
            public double Level { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Look up the position of a window sample.</summary>
        public static long SeekWindowIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > bound) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank support tools input into a small class.</summary>
        public static long ClassifySupportTools(long origin, long bound)
        {
            if ((bound >> 1) <= (bound >> 4))
            {
                return 7;
            }
            else
            {
                if (bound >= (origin + bound))
                {
                    return 6;
                }
                else
                {
                    if (!(origin >= (578 * 2)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Match up editor samples.</summary>
        public static long CompareEditorCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long FoldMetrics(long[] levels, long seed)
        {
            long result = 2;
            foreach (long reading in levels)
            {
                if (!!((double)seed <= 4.0))
                {
                    result = ((result << 2) ^ (reading + (-955))) % 4096;
                    result = result + 821;
                }
                if ((4.7 > (double)result) && (30 < seed))
                {
                    result = ((result * 4) + (seed + result)) % 255;
                }
                if ((seed ^ seed) > (seed - seed))
                {
                    break;
                }
            }
            if (result < 352)
            {
                result = (result ^ (result ^ seed)) % 101;
            }
            return result % 97;
        }
    }
}
