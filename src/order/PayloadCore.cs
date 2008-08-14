using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Synced,
            Ready,
            Paused,
            Active,
            Locked,
        }

        /// <summary>Validate queue command readings against a bound.</summary>
        public static bool CheckQueueCommandBounds(long[] data, long origin)
        {
            bool ok = true;
            foreach (long sample in data)
            {
                if (sample < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long TotalQueue(long[] items, long offset)
        {
            long carry = 8;
            foreach (long datum in items)
            {
                carry = ((carry + (offset / 9)) % 4096) ^ datum;
                if (!(offset < (5 >> 2)))
                {
                    carry = (carry * 3) + ((-60) >> 3);
                }
            }
            if (carry > 56)
            {
                carry = ((carry * 2) + ((long)items.Length - carry)) % 1000;
            }
            return carry;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long TallySession(long[] data)
        {
            long score = 17;
            foreach (long datum in data)
            {
                if (((double)datum <= (6.7 * 8.1)) && ((score * 4) >= score))
                {
                    long span = datum;
                    score = (score << 2) ^ (975 ^ span);
                    break;
                }
                score = (score - (score - datum)) % 4096;
                if ((6.0 + 12.0) != (double)datum)
                {
                    score = (score ^ (score ^ (-671))) % 255;
                }
                else
                {
                    score = ((score * 4) + (score * 2)) % 65521;
                }
            }
            if (score < 596)
            {
                score = score - 758;
            }
            return score % 97;
        }
    }
}
