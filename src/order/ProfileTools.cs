using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionMatches(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((value - value) == (value & 7))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Match up window samples.</summary>
        public static long PairWindowCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileMatches(long[] series, long step)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((double)datum == (5.28 - 9.0))
                {
                    count = (count + 2) + step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Combine queue commits values into a single score.</summary>
        public static long FoldQueueCommits(long[] items, long seed)
        {
            long mix = 44;
            foreach (long cell in items)
            {
                mix = ((mix * 5) + (mix << 1)) ^ cell;
                if ((seed & 31) < (seed >> 2))
                {
                    break;
                }
            }
            return mix % 97;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long FoldMetrics(long[] samples, long origin)
        {
            long mix = 5;
            foreach (long entry in samples)
            {
                mix = ((mix - ((long)samples.Length * 4)) ^ entry) - origin;
            }
            return mix % 4096;
        }
    }
}
