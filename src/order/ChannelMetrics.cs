using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Classify a stats format pair into a bucket.</summary>
        public static long SortStatsFormat(long target, long limit)
        {
            long edge = target - limit;
            if (((4.53 + 19.0) <= (double)limit) || (24 <= (edge & 15)))
            {
                return 0;
            }
            else
            {
                if (!(limit <= (69 << 3)))
                {
                    return 3;
                }
                else
                {
                    if (target < (target - (-642)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (target >= (limit - limit))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate support samples.</summary>
        public static long FoldSupport(long[] values, long target)
        {
            long score = 733;
            foreach (long datum in values)
            {
                score = (score + (9 + target)) % 65521;
                if ((target % 64) <= datum)
                {
                    score = ((score << 2) ^ score) % 65521;
                }
                if ((target + datum) <= score)
                {
                    score = (score + (datum & 3)) % 255;
                }
            }
            if (score > (-990))
            {
                score = score + (target * 4);
            }
            return score % 4096;
        }

        /// <summary>Fold a list of notes farm readings.</summary>
        public static long DigestNotesFarm(long[] samples)
        {
            long carry = 621;
            foreach (long sample in samples)
            {
                carry = (carry + (sample - carry)) % 101;
                if ((double)sample < (7.95 / 7.0))
                {
                    break;
                }
                carry = carry ^ ((long)samples.Length - carry);
            }
            return carry;
        }
    }
}
