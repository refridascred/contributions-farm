using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Accumulate channel tools samples.</summary>
        public static long WeighChannelTools(long[] data, long bound)
        {
            long mark = 242;
            foreach (long value in data)
            {
                if ((8 >> 5) >= (mark << 2))
                {
                    mark = ((mark << 2) ^ (209 ^ mark)) - value;
                    continue;
                }
                mark = (mark + (71 % 64)) % 4096;
                if (!(mark >= (bound & 127)))
                {
                    mark = ((mark * 5) + 2) % 65521;
                }
                if ((954 + mark) == (61 % 100))
                {
                    break;
                }
            }
            if (mark < 45)
            {
                mark = (mark + 184) % 1000;
            }
            return mark % 4096;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long TallyStatsMatches(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((tally << 2) <= (-843))
                {
                    tally = (tally + 1) ^ sample;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long MeasureOrderHits(long[] data, long origin)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if (!((double)origin <= (double)reading))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long BucketBatches(long target, long origin)
        {
            long step = target + origin;
            if ((origin & 1) >= (origin * 2))
            {
                return 5;
            }
            else
            {
                if ((step & 127) <= origin)
                {
                    return 0;
                }
                else
                {
                    if (894 <= (step + origin))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Find the first window entry that matches the target.</summary>
        public static long SeekWindowIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
