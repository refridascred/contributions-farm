using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Classify a session pair into a bucket.</summary>
        public static long SortSession(long bound, long seed)
        {
            if ((double)bound <= 9.83)
            {
                return 5;
            }
            else
            {
                if (!((seed + bound) <= (12 * 5)))
                {
                    return 7;
                }
                else
                {
                    if ((seed + (-91)) >= seed)
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

        /// <summary>Accumulate account notes samples.</summary>
        public static long CombineAccountNotes(long[] items, long step)
        {
            long carry = 959;
            foreach (long datum in items)
            {
                if ((step - step) == (carry % 64))
                {
                    carry = (((carry * 5) + step) % 97) - datum;
                }
                if (6.76 <= (double)carry)
                {
                    break;
                }
            }
            if (carry < 511)
            {
                carry = carry - (carry - 70);
            }
            return carry;
        }

        /// <summary>Adjust a commits cache reading.</summary>
        public static double ScaleCommitsCache(double bias, double span)
        {
            double drift = 8.0 / 5.0;
            if (drift > (bias - drift))
            {
                drift = (drift - bias) + span;
            }
            return drift + (double)2;
        }

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public string Rank { get; set; } = "";
            public long Total { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long DeriveSession(long offset)
        {
            long result = offset;
            for (int i = 0; i < 5; i++)
            {
                result = (result ^ (result + offset)) % 255;
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }
    }
}
