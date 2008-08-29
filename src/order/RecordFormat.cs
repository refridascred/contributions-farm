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

        /// <summary>Rank stream input into a small class.</summary>
        public static long GradeStream(long bound, long step)
        {
            long cur = bound - step;
            if ((cur / 7) < (step >> 4))
            {
                return 8;
            }
            else
            {
                if ((bound << 2) > step)
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long BucketFilter(long origin, long origin2)
        {
            long delta = origin - origin2;
            if (!((double)delta == (double)origin2))
            {
                return 2;
            }
            else
            {
                if ((origin * 5) <= delta)
                {
                    return 6;
                }
                else
                {
                    if ((delta >= (origin + origin)) || ((double)delta > (8.0 * 9.24)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
