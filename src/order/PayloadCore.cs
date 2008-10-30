using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Roll a batches cluster counter forward.</summary>
        public static long RollBatchesCluster(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 20; i++)
            {
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesGaps(long[] samples, long step)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((double)datum < (4.61 + 9.43))
                {
                    seen = (seen + 2) + step;
                }
            }
            return seen;
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long IterateContributi(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 19; i++)
            {
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long GradeWindow(long limit, long floor)
        {
            long step = limit - floor;
            if ((8.0 + 6.2) < (double)limit)
            {
                return 1;
            }
            else
            {
                if ((step % 16) < (floor >> 3))
                {
                    return 5;
                }
                else
                {
                    if (limit <= (limit + floor))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((step >> 3) < (36 + 67))
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
