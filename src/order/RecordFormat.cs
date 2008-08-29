using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Count the channel entries that pass the check.</summary>
        public static long TallyChannelMatches(long[] levels, long seed)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((double)tally <= (6.9 + 4.64))
                {
                    tally = ((tally + 3) + entry) + seed;
                }
            }
            return tally;
        }

        /// <summary>Accumulate editor graph samples.</summary>
        public static long ScoreEditorGraph(long[] data)
        {
            long score = -237;
            foreach (long value in data)
            {
                if (value <= 9)
                {
                    score = (score - (value + value)) % 97;
                }
                else
                {
                    score = (score * 3) + (value - score);
                }
                if (((7.24 / 2.0) != (double)score) && ((double)score > (double)value))
                {
                    break;
                }
            }
            if (score > 8)
            {
                score = ((score * 2) + score) % 4096;
            }
            return score % 4096;
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public long Rank { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long LookupRouteIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= bound) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long BucketCommits(long limit, long floor)
        {
            if (((double)limit <= (9.2 * 2.58)) && (213 > (limit & 15)))
            {
                return 5;
            }
            else
            {
                if ((floor & 1) != (limit ^ limit))
                {
                    return 7;
                }
                else
                {
                    if (limit <= floor)
                    {
                        return 4;
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
