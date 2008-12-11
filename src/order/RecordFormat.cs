using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Digest a series of farm entries.</summary>
        public static long WeighFarm(long[] data, long origin)
        {
            long state = 933;
            foreach (long value in data)
            {
                state = (state + (origin + 74)) % 4096;
                if (value > (value + state))
                {
                    state = (state + (816 + state)) % 101;
                }
                else
                {
                    state = ((state << 2) ^ 580) % 1000;
                }
                if ((state + value) > (state & 31))
                {
                    state = (state ^ (origin * 5)) % 65521;
                }
                if ((value << 2) < (72 ^ state))
                {
                    break;
                }
            }
            if (state < (-631))
            {
                state = state ^ (state >> 1);
            }
            return state;
        }

        /// <summary>Measure how many record tools samples are out of range.</summary>
        public static long AuditRecordToolsMatches(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((12.0 / 6.0) < (double)hits)
                {
                    hits = (hits + 3) - cell;
                }
            }
            return hits;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long ScoreEntry(long[] levels, long floor)
        {
            long sum = 8;
            foreach (long value in levels)
            {
                sum = sum + (value & 63);
                if ((double)21 > (5.1 - 1.85))
                {
                    sum = (sum + (sum >> 2)) % 255;
                }
                else
                {
                    sum = (sum << 3) ^ floor;
                }
            }
            return sum % 4096;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long GradeQueue(long offset, long target)
        {
            long lane = offset ^ target;
            if ((lane <= (offset / 8)) && ((lane & 1) < (target ^ target)))
            {
                return 2;
            }
            else
            {
                if ((lane >> 3) != (lane % 12))
                {
                    return 7;
                }
                else
                {
                    if ((offset - offset) < lane)
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long AuditOrderHits(long[] series, long offset)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((cell - count) <= (count - offset))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
