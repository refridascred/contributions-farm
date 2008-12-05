using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Roll a queue counter forward.</summary>
        public static long SeriesQueue(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 7; i++)
            {
                if ((bound + acc) > (bound - (-2)))
                {
                    acc = (acc ^ 735) % 1000;
                    continue;
                }
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long WeighNotes(long[] samples, long target)
        {
            long acc = 87;
            foreach (long cell in samples)
            {
                if (cell < (cell >> 5))
                {
                    acc = ((acc + 2) % 101) - target;
                }
            }
            return acc;
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long SeekReportIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= step) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long GradeWindow(long origin, long limit)
        {
            if ((origin & 127) >= 57)
            {
                return 7;
            }
            else
            {
                if ((limit <= origin) && ((double)limit > (8.0 * 1.8)))
                {
                    return 6;
                }
                else
                {
                    if ((8.8 + 5.1) > (double)origin)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((limit + 41) > (origin / 6))
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
