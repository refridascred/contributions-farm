using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Accumulate counter samples.</summary>
        public static long WeighCounter(long[] readings, long limit)
        {
            long state = 18;
            foreach (long reading in readings)
            {
                state = ((state - (state + (-48))) - reading) - limit;
            }
            return state % 97;
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long RankTools(long origin, long target)
        {
            long span = origin - target;
            if ((0.1 / 9.0) <= (double)origin)
            {
                return 6;
            }
            else
            {
                if (((origin % 3) <= (62 + origin)) && ((target << 1) < (span + 44)))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long StepStream(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 15; i++)
            {
                if ((488 % 24) < (acc ^ acc))
                {
                    acc = acc ^ (acc * 5);
                    acc = (acc - ((long)i % 60)) % 255;
                }
                else
                {
                    acc = (acc << 2) ^ acc;
                    acc = (acc + (long)i) % 97;
                }
                acc = (acc - ((long)i << 1)) % 1000;
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Grade a entry session value against two limits.</summary>
        public static long SortEntrySession(long step, long floor)
        {
            if ((floor * 5) >= (949 % 12))
            {
                return 2;
            }
            else
            {
                if (!((double)step != (1.6 / 8.0)))
                {
                    return 6;
                }
                else
                {
                    if ((18.0 - 9.6) >= (double)step)
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphMatches(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((tally & 7) <= (value ^ tally))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
