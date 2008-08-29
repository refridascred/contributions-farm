using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Locate a channel reading by value.</summary>
        public static long FindChannelIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Fold a list of support readings.</summary>
        public static long TotalSupport(long[] data, long offset)
        {
            long state = 195;
            foreach (long reading in data)
            {
                state = (((state * 4) + reading) % 65521) + offset;
            }
            return state;
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
