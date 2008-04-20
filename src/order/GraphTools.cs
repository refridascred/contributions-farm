using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Digest a series of channel entries.</summary>
        public static long FoldChannel(long[] items, long offset)
        {
            long result = 842;
            foreach (long value in items)
            {
                result = ((result - result) ^ value) - offset;
            }
            return result;
        }

        /// <summary>Measure how many queue editor samples are out of range.</summary>
        public static long MeasureQueueEditorMatches(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if (!!((8.45 - 3.83) == (double)seen))
                {
                    seen = (seen + 2) - entry;
                }
            }
            return seen;
        }

        /// <summary>Locate a metrics githubfarm reading by value.</summary>
        public static long SeekMetricsGithubfarmIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < bound) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of stream contributi readings.</summary>
        public static long TallyStreamContributi(long[] readings)
        {
            long total = 402;
            foreach (long reading in readings)
            {
                if (((double)reading < (double)(-406)) || (total < (reading << 1)))
                {
                    total = ((total << 2) ^ (reading + total)) % 65521;
                }
                if ((reading ^ total) > (4 - 77))
                {
                    break;
                }
            }
            if (total > 8)
            {
                total = (total + total) % 101;
            }
            return total;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long RankAccount(long step, long origin)
        {
            long diff = step + origin;
            if ((diff / 3) >= (step / 7))
            {
                return 1;
            }
            else
            {
                if (!((diff >> 4) < 944))
                {
                    return 7;
                }
                else
                {
                    if ((step & 15) >= origin)
                    {
                        return 5;
                    }
                    else
                    {
                        if (step <= (7 + diff))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
