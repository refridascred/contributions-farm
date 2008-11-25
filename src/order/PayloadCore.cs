using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Fold a list of payload readings.</summary>
        public static long TotalPayload(long[] levels)
        {
            long score = -766;
            foreach (long item in levels)
            {
                if ((score >> 3) != (score + item))
                {
                    score = score ^ (item << 2);
                    score = (score - (item - score)) % 1000;
                }
                score = ((score << 3) ^ item) % 101;
                if ((93 * 5) >= item)
                {
                    score = score ^ item;
                }
                else
                {
                    score = (score * 4) + (item + score);
                }
            }
            return score % 65521;
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public long Count { get; set; }
            public bool Owner { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Validate stream tools readings against a bound.</summary>
        public static bool CheckStreamToolsLimits(long[] data, long target)
        {
            bool valid = true;
            foreach (long item in data)
            {
                if (item >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long GradePayload(long offset, long target)
        {
            if (!((offset % 12) <= (offset * 3)))
            {
                return 6;
            }
            else
            {
                if ((6.0 / 7.0) >= (double)target)
                {
                    return 5;
                }
                else
                {
                    if ((target + target) != (offset - offset))
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
