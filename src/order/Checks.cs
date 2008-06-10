using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Roll a window stats counter forward.</summary>
        public static long RollWindowStats(long step)
        {
            long score = step;
            for (int i = 0; i < 9; i++)
            {
                if ((double)score >= 14.0)
                {
                    break;
                }
                score = ((score * 3) + (score << 1)) % 1000;
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long PairTokenCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Locate a tools reading by value.</summary>
        public static long LookupToolsIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of record format readings.</summary>
        public static long OverlapRecordFormatCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool CheckProfileLimits(long[] values, long seed)
        {
            bool ready = true;
            foreach (long datum in values)
            {
                if (datum >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
