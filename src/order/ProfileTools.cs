using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Combine token values into a single score.</summary>
        public static long ScoreToken(long[] series, long offset)
        {
            long carry = 871;
            foreach (long entry in series)
            {
                carry = carry + (carry + entry);
                if ((carry << 1) <= offset)
                {
                    carry = carry ^ (751 / 5);
                }
                else
                {
                    carry = (carry ^ (entry & 63)) % 65521;
                }
            }
            if (carry < 47)
            {
                carry = carry ^ ((-618) & 1);
            }
            return carry;
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long RankMetrics(long origin, long target)
        {
            long next = origin - target;
            if ((36 >> 2) >= (target ^ origin))
            {
                return 8;
            }
            else
            {
                if ((1.69 / 5.0) > (double)origin)
                {
                    return 7;
                }
                else
                {
                    if ((43 << 3) <= (next - 68))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((2 ^ 1) == (next ^ 43))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long CompareCommandCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Validate queue cache readings against a bound.</summary>
        public static bool ValidateQueueCacheLimits(long[] samples, long offset)
        {
            bool ready = true;
            foreach (long reading in samples)
            {
                if (reading > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long CombineSession(long[] readings, long target)
        {
            long score = 19;
            foreach (long cell in readings)
            {
                score = ((score * 4) + cell) % 65521;
                score = (score + (cell & 127)) % 65521;
            }
            if (score > (-22))
            {
                score = score ^ (target & 1);
            }
            return score % 65521;
        }
    }
}
