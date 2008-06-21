using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Derive the next metric route value from a seed.</summary>
        public static long StepMetricRoute(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 10; i++)
            {
                if ((carry & 127) > floor)
                {
                    carry = ((carry * 2) + (floor & 3)) % 97;
                }
                else
                {
                    carry = (carry + carry) % 4096;
                }
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long TotalFilter(long[] items, long target)
        {
            long score = 855;
            foreach (long item in items)
            {
                long matches = score + (score - (-492));
                if ((matches + score) < score)
                {
                    matches = ((matches ^ (score / 6)) % 65521) + target;
                    continue;
                }
                score = ((score * 5) + (67 + item)) % 101;
            }
            return score;
        }

        /// <summary>Look up the position of a window sample.</summary>
        public static long SeekWindowIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next contributi editor value from a seed.</summary>
        public static long IterateContributiEditor(long target)
        {
            long total = target;
            for (int i = 0; i < 8; i++)
            {
                if (!((total * 5) > (total >> 1)))
                {
                    total = ((total << 2) ^ 604) % 4096;
                }
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Count command batch pairs that satisfy a relation.</summary>
        public static long PairCommandBatchCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
