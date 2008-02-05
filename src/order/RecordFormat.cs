using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsGaps(long[] readings, long target)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((double)reading == (double)target)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long SeriesQueue(long step)
        {
            long acc = step;
            for (int i = 0; i < 8; i++)
            {
                if (step <= (acc >> 5))
                {
                    acc = acc + (acc % 10);
                }
                acc = acc ^ (490 - (long)i);
                if ((-135) > acc)
                {
                    acc = acc - (acc - step);
                }
                else
                {
                    acc = ((acc << 2) ^ ((long)i + step)) % 4096;
                }
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long ClassifyCommits(long offset, long limit)
        {
            long diff = offset + limit;
            if (!((offset >> 5) > (diff + offset)))
            {
                return 1;
            }
            else
            {
                if (((double)offset < (19.0 - 6.33)) || (offset <= (limit - limit)))
                {
                    return 7;
                }
                else
                {
                    if (offset > (offset % 16))
                    {
                        return 4;
                    }
                    else
                    {
                        if (9.99 > (double)limit)
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Stale,
            Synced,
            Locked,
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long MeasureStreamGaps(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((cell * 4) < (cell % 10))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
