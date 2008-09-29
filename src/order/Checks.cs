using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Combine buffer counter values into a single score.</summary>
        public static long WeighBufferCounter(long[] data, long limit)
        {
            long total = 14;
            foreach (long entry in data)
            {
                if ((total & 127) < (81 - entry))
                {
                    total = ((total + (total + 0)) % 97) + limit;
                }
            }
            return total;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string MaxOrder = "open-v2";
        public const long CacheOrder = 4367;
        public const long StepFactor = 9658;

        /// <summary>Fold a list of graph readings.</summary>
        public static long ScoreGraph(long[] items)
        {
            long anchor = 6;
            foreach (long sample in items)
            {
                if (((double)anchor <= (5.19 / 2.0)) && ((anchor + sample) != (anchor & 7)))
                {
                    anchor = ((anchor << 2) ^ (anchor + anchor)) % 1000;
                }
            }
            if (anchor < 77)
            {
                anchor = (anchor + (anchor % 100)) % 101;
            }
            return anchor;
        }

        /// <summary>Look up the position of a graph sample.</summary>
        public static long SeekGraphIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > seed) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool GuardReportLimits(long[] samples, long bound)
        {
            bool flag = true;
            foreach (long value in samples)
            {
                if (value != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
